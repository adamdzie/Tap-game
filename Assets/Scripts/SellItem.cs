using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SellItem : MonoBehaviour, IDropHandler
{
    Player player;
    Inventory inventory;
    ResourcesScript resourcesScript;
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        player = Player.instance;
        resourcesScript = ResourcesScript.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerPress != null)
        {
            player.Gold += eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().GetItem().price;
            resourcesScript.updateGold();
            inventory.Insert(eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().index, new Item());
        }
        
    }
}
