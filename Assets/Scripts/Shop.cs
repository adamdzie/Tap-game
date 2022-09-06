using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.Threading;
public class Shop : MonoBehaviour
{


    Text rerollTimer;
    Text category;
    Stopwatch stopWatch;
    ItemStorage itemStorage;

    private const int SHOP_SIZE = 13;
    private const int REROLL_TIME_SECONDS = 10;

    GameObject dialogBox;

    private int partShop;
    private List<Item> shop_Swords;
    private List<Item> shop_Armors;
    private List<Item> shop_Helmets;
    private List<Item> shop_Boots;
    private List<Item> shop_Gloves;
    private List<Item> shop_Neclaces;
    private List<Item> shop_Trousers;
    private List<Item> shop_Consumables;
    private List<List<Item>> shop_centre;

    public ShopSlot [] slots;

    // Start is called before the first frame update
    void Awake()
    {
    partShop = 0;
    

    }
    void Start()
    {
        stopWatch = new Stopwatch();
        stopWatch.Start();
        UnityEngine.Debug.Log(stopWatch.Elapsed.Seconds);
        itemStorage = ItemStorage.instance;
        shop_Swords = new List<Item>();
        shop_Armors = new List<Item>();
        shop_Helmets = new List<Item>();
        shop_Boots = new List<Item>();
        shop_Gloves= new List<Item>();
        shop_Neclaces = new List<Item>();
        shop_Trousers = new List<Item>();
        shop_Consumables = new List<Item>();
        shop_centre = new List<List<Item>>();
        rerollTimer = gameObject.transform.GetChild(0).transform.GetChild(0).transform.GetChild(3).transform.GetComponent<Text>();
        category = gameObject.transform.GetChild(0).transform.GetChild(0).transform.GetChild(2).transform.GetComponent<Text>();


        slots = gameObject.transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).transform.GetComponentsInChildren<ShopSlot>();
        ChangeItems();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRerollTime();
        if (stopWatch.Elapsed.Seconds > REROLL_TIME_SECONDS)
        {
            ChangeItems();
            stopWatch.Reset();
            stopWatch.Start();
        }

    }
    void ChangeCategory()
    {
        switch (partShop)
        {
            case 0:
                category.text = "Swords";
                break;
            case 1:
                category.text = "Armors";
                break;
            case 2:
                category.text = "Helmets";
                break;
            case 3:
                category.text = "Boots";
                break;
            case 4:
                category.text = "Gloves";
                break;
            case 5:
                category.text = "Neclaces";
                break;
            case 6:
                category.text = "Trousers";
                break;
            case 7:
                category.text = "Consumable";
                break;
        }
    }


    void UpdateRerollTime()
    {
        rerollTimer.text = "Shop Reroll: " + (REROLL_TIME_SECONDS - stopWatch.Elapsed.Seconds); 
    }
    public void Previous()
    {
        if (partShop == 0) partShop = 7;
        else partShop--;
        PutItemsToSlots();
        ChangeCategory();
    }
    public void Next()
    {
        if (partShop == 7) partShop = 0;
        else partShop++;
        PutItemsToSlots();
        ChangeCategory();
    }

    private void ChangeItems()
    {
        shop_Swords.Clear();
        shop_Armors.Clear();
        shop_Helmets.Clear();
        shop_Boots.Clear();
        shop_Gloves.Clear();
        shop_Neclaces.Clear();
        shop_Trousers.Clear();
        shop_Consumables.Clear();
        UnityEngine.Debug.Log(itemStorage.Swords.Count);
        for (int i = 0; i < SHOP_SIZE; i++) shop_Swords.Add(itemStorage.Swords[Random.Range(0, itemStorage.Swords.Count - 1)]);
        for (int i = 0; i < SHOP_SIZE; i++) shop_Armors.Add(itemStorage.Armors[Random.Range(0, itemStorage.Armors.Count - 1)]);
        for (int i = 0; i < SHOP_SIZE; i++) shop_Helmets.Add(itemStorage.Helmets[Random.Range(0, itemStorage.Helmets.Count - 1)]);
        for (int i = 0; i < SHOP_SIZE; i++) shop_Boots.Add(itemStorage.Boots[Random.Range(0, itemStorage.Boots.Count - 1)]);
        for (int i = 0; i < SHOP_SIZE; i++) shop_Gloves.Add(itemStorage.Gloves[Random.Range(0, itemStorage.Gloves.Count - 1)]);
        for (int i = 0; i < SHOP_SIZE; i++) shop_Neclaces.Add(itemStorage.Neclaces[Random.Range(0, itemStorage.Neclaces.Count - 1)]);
        for (int i = 0; i < SHOP_SIZE; i++) shop_Trousers.Add(itemStorage.Trousers[Random.Range(0, itemStorage.Trousers.Count - 1)]);
        for (int i = 0; i < SHOP_SIZE; i++) shop_Consumables.Add(itemStorage.Consumables[Random.Range(0, itemStorage.Consumables.Count - 1)]);
        shop_centre.Clear();
        shop_centre.Add(shop_Swords);
        shop_centre.Add(shop_Armors);
        shop_centre.Add(shop_Helmets);
        shop_centre.Add(shop_Boots);
        shop_centre.Add(shop_Gloves);
        shop_centre.Add(shop_Neclaces);
        shop_centre.Add(shop_Trousers);
        shop_centre.Add(shop_Consumables);
        PutItemsToSlots();
    }
    private void PutItemsToSlots()
    {
        for(int i = 0; i<SHOP_SIZE; i++)
        {
            switch (partShop)
            {
                case 0:
                    slots[i].UpdateItem(shop_centre[0][i]);
                    slots[i].OnItemChange();
                    break;
                case 1:
                    slots[i].UpdateItem(shop_centre[1][i]);
                    slots[i].OnItemChange();
                    break;
                case 2:
                    slots[i].UpdateItem(shop_centre[2][i]);
                    slots[i].OnItemChange();
                    break;
                case 3:
                    slots[i].UpdateItem(shop_centre[3][i]);
                    slots[i].OnItemChange();
                    break;
                case 4:
                    slots[i].UpdateItem(shop_centre[4][i]);
                    slots[i].OnItemChange();
                    break;
                case 5:
                    slots[i].UpdateItem(shop_centre[5][i]);
                    slots[i].OnItemChange();
                    break;
                case 6:
                    slots[i].UpdateItem(shop_centre[6][i]);
                    slots[i].OnItemChange();
                    break;
                case 7:
                    slots[i].UpdateItem(shop_centre[7][i]);
                    slots[i].OnItemChange();
                    break;
            }
        }
    }
}
