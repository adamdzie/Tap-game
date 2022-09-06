using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    public Transform equipmentParent;
    Inventory inventory;
    Player player;
    InventorySlot[] slots;
    InventorySlot[] eq_slots;
    // Start is called before the first frame update
  
    void Start()
    {
        
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        eq_slots = equipmentParent.GetComponentsInChildren<InventorySlot>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].index = i;
        }
        int a = slots.Length;
        for(int i = 0; i < eq_slots.Length; i++)
        {
            eq_slots[i].index = a;
            a++;
        }
        eq_slots[0].slotType = Item.ItemType.Sword;
        eq_slots[1].slotType = Item.ItemType.Helmet;
        eq_slots[2].slotType = Item.ItemType.Armor;
        eq_slots[3].slotType = Item.ItemType.Trousers;
        eq_slots[4].slotType = Item.ItemType.Boots;
        eq_slots[5].slotType = Item.ItemType.Gloves;
        eq_slots[6].slotType = Item.ItemType.Neclace;

    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
       //if(eq_slots[0].icon != null)
        //{
        //    player.Sword_view.sprite = eq_slots[0].GetItem().idle_view;
           
       // }
    }
    
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].AddItem(inventory.itemList[i]);
        }
        int a = slots.Length;
        for (int i = 0; i < eq_slots.Length; i++)
        {
            eq_slots[i].AddItem(inventory.itemList[a]);
            a++;
        }
    }
}
  
