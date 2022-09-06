using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopSlot : MonoBehaviour
{
    ResourcesScript resourcesScript;
    Player player;
    Inventory inventory;
    ItemStorage itemStorage;
    private Item item;
    private Image image;
    private Text itemAttr1,itemAttr2,itemAttr3,itemAttr4,itemAttr5,itemAttr6;
    public Button buyButt;
    DialogWindow dialogWindow;
    public Button yesButt;
    public Button noButt;
    void Awake()
    {
        image = gameObject.transform.GetChild(0).transform.GetChild(0).transform.GetComponent<Image>();
        itemAttr1 = gameObject.transform.GetChild(2).transform.GetChild(0).transform.GetComponent<Text>();
        itemAttr2 = gameObject.transform.GetChild(2).transform.GetChild(1).transform.GetComponent<Text>();
        itemAttr3 = gameObject.transform.GetChild(2).transform.GetChild(2).transform.GetComponent<Text>();
        itemAttr4 = gameObject.transform.GetChild(2).transform.GetChild(3).transform.GetComponent<Text>();
        itemAttr5 = gameObject.transform.GetChild(2).transform.GetChild(4).transform.GetComponent<Text>();
        itemAttr6 = gameObject.transform.GetChild(2).transform.GetChild(5).transform.GetComponent<Text>();
        buyButt = gameObject.transform.GetComponent<Button>();
        dialogWindow = gameObject.transform.GetChild(1).transform.GetChild(0).GetComponent<DialogWindow>();
        yesButt = gameObject.transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).GetComponent<Button>();
        noButt = gameObject.transform.GetChild(1).transform.GetChild(0).transform.GetChild(1).GetComponent<Button>();

    }
    void Start()
    {
        resourcesScript = ResourcesScript.instance;
        player = Player.instance;
        itemStorage = ItemStorage.instance;
        inventory = Inventory.instance;
        buyButt.onClick.AddListener(buyItem);
        yesButt.onClick.AddListener(buyItemAfter);
        noButt.onClick.AddListener(dontBuy);
        item = itemStorage.ItemBase[0];
        image.sprite = item.iconing;
        generateItemDesc();
    }
    public void UpdateItem(Item it)
    {
        item = it;
    }
    public void OnItemChange()
    {
        image.sprite = item.iconing;
        generateItemDesc();
    }

    //Kiedy zaczynamy kopowac
    public void buyItem()
    {
        dialogWindow.activeObject();
    }

    //Po potwierdzeniu w oknie dialogowym
    public void buyItemAfter()
    {
        int index = inventory.ReturnFirstFreeSlotIndex();
        if (index != 1000 && player.Gold >= item.price)
        {
            inventory.Insert(index, item);
            player.Gold -= item.price;
            resourcesScript.updateGold();
        }
        else Debug.Log("Nie ma miejsca w eq");
        
        dialogWindow.deactiveObject();
    }
    //Po kliknieciu "nie" w oknie dialogowym
    public void dontBuy()
    {
            dialogWindow.deactiveObject();
    }
    private void generateItemDesc()
    {
        itemAttr1.text = "Price: " + item.price;
        itemAttr2.text = "Damage: " + item.damage;
        itemAttr3.text = "Health: " + item.health;
        itemAttr4.text = "Critical chance: " + item.critical_chance;
        itemAttr5.text = "Defence: " + item.defence;
        itemAttr6.text = "Ability power: " + item.ability_power;
    }
}
