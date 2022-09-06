using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tooltip : MonoBehaviour
{
    InventorySlot slot;
    Text itemStats;
    Item item;
    Transform self;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {

        item = null;
        itemStats = null;
        self = GetComponent<Transform>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame

    public void OnActive(InventorySlot slots)
    {
        slot = slots;
        item = slots.GetItem();
        itemStats = GetComponentInChildren<Text>();
        if(item != null)
        {
            Debug.Log(itemStats.text);
            itemStats.text = "Price: " + item.value + "\n\n" + item.description + "\n" + item.name;
            Vector3 slotPos = slot.GetComponent<Transform>().position;
            slotPos.x = slotPos.x + (slot.GetComponent<RectTransform>().sizeDelta.x / 2);
            self.position = slotPos;
            gameObject.SetActive(true);
        }
        
    }
    public void OffTooltip()
    {
        gameObject.SetActive(false);
    }
    public void check()
    {
        Debug.Log("esaa");
    }
}
