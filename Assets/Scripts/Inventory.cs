using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool isClicked = false;
    public delegate void OnEquipmentChange();
    OnEquipmentChange onEquipmentChangeCallback;
    #region Singleton
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    Player player;
    public static Inventory instance;
    public List<Item> itemList;
    private const int INVENTORY_SIZE = 42;
    private const int EQUIPMENT_SIZE = 7;
    private int size = INVENTORY_SIZE + EQUIPMENT_SIZE;

    void Awake()
    {
        itemList = new List<Item>();
        AddItem(new Item(500, "xaxaxa", Item.ItemType.Enhancer, 0, "Sword",10,20,5f,20,10, 300));
        AddItem(new Item(500, "xaxaxa", Item.ItemType.Armor, 0, "Sword",2,3,3f,40,20, 300));
        AddItem(new Item(500, "xaxaxa", Item.ItemType.Sword, 1, "Sword2",5,6,2f,100,30, 300));
        for (int i = 3; i<size; i++)
        {
           AddItem(new Item());
        }
        //addit(new Item (500, "xaxaxa",Item.ItemType.Sword, 0, "Sword"));

        if (instance != null)
        {
            Debug.LogWarning("More than one instance");
        }
        instance = this;
    }

    #endregion
    void Start()
    {
        onEquipmentChangeCallback += SetPlayerItems;
        //player = Player.instance;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    void Update()
    {
        if(isClicked)
        onItemChangedCallback.Invoke();
   
    }
    

    public void AddItem(Item item)
    {
        itemList.Add(item);
        if(onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
            onEquipmentChangeCallback.Invoke();
        }
        
    }
    public void Insert(int index, Item item)
    {
        itemList[index] = item;
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
            onEquipmentChangeCallback.Invoke();
        }
    }
    public void Remove (Item item)
    {
        itemList.Remove(item);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
            onEquipmentChangeCallback.Invoke();
        }
    }
    public void SetPlayerItems()
    {
        player.SetSword(itemList[42]);
        player.SetHelmet(itemList[43]);
        player.SetArmor(itemList[44]);
        player.SetTrousers(itemList[45]);
        player.SetBoots(itemList[46]);
        player.SetGloves(itemList[47]);
        player.SetNeclace(itemList[48]);
    }
    public List<Item> GetItemList()
    {
        return itemList;
    }
    public int GetSize()
    {
        return size;
    }
    public int ReturnFirstFreeSlotIndex()
    {
        for(int i = 0; i<INVENTORY_SIZE; i++)
        {
            if (itemList[i].name == null) return i;
        }
        return 1000;
    }
}
   
