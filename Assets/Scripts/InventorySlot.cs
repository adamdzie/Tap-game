
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class InventorySlot : MonoBehaviour,IDropHandler
{
    public Image icon;
    public Image icon_active;
    Item item;
    Inventory inventory;
    public int index;
    public Item.ItemType slotType;
    void Start()
    {
        inventory = Inventory.instance;
    }
    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.iconing;
        if (item.iconing != null) icon.enabled = true;
        else
        {
            icon.sprite = null;
            icon.enabled = false;
        }



    }
    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        
    }
    public void OnActiveSlot()
    {
        icon_active.enabled = true;
    }
    public void OffIcon()
    {
        icon_active.enabled = false;
        //icon.enabled = false;
    }
    public Item GetItem()
    {
        return item;
    }


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrops");
        if (index < 42)
        {
            RevItems(eventData);
        }
        else if (eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().GetItem().itemType == slotType)
        {
                RevItems(eventData);
        }
      
    }
    void RevItems(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (item.iconing == null)
            {
                Debug.Log(eventData.pointerDrag.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().index);
                inventory.Insert(index, eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().GetItem());
                inventory.Insert(eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().index, new Item());

            }
            else if (item.iconing != null)
            {

                Debug.Log("HALO JESTEM TUTAJ");
                Item it = eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().GetItem();
                inventory.Insert(eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().index, item);
                inventory.Insert(index, it);
            }

        }
    }
}
