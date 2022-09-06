using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public static Player instance;
    public delegate void OnEquipmentChange();
    public OnEquipmentChange onEquipmentChangeCallback;
    public Sprite Helmet_view;
    public Sprite Armor_view;
    public Sprite Sword_view;
    public Sprite Trousers_view;

    Image Helmet_view_im, Armor_view_im, Sword_view_im, Trousers_view_im;
    public int Health;
    public int Damage;
    public int Defence;
    public int AbilityPower;
    public float CriticalChance;

    //Waluta
    public int Gold;
    public int Crystals;

    //Ekwipunek
    Item Helmet;
    Item Armor;
    public  Item Sword;
    Item Trousers;
    Item Boots;
    Item Gloves;
    Item Neclace;
    Inventory inventory;
    PlayerStats stats;
    bool something_changed = false;
    void Awake()
    {
        Gold = 100000;
        Crystals = 0;
        Health = 100;
        Damage = 10;
        Defence = 0;
        AbilityPower = 0;
        CriticalChance = 0;

        Helmet = new Item();
        Armor = new Item();
        Sword = new Item();
        Trousers = new Item();
        Boots = new Item();
        Gloves = new Item();
        Neclace = new Item();
        instance = this;

        Helmet_view_im = gameObject.transform.GetChild(0).GetComponentInChildren<Image>();
        Armor_view_im = gameObject.transform.GetChild(1).GetComponentInChildren<Image>();
        Sword_view_im = gameObject.transform.GetChild(3).GetComponentInChildren<Image>();
        Trousers_view_im = gameObject.transform.GetChild(2).GetComponentInChildren<Image>();
    }
    void Start()
    {
        inventory = Inventory.instance;
        stats = PlayerStats.instance;
        Debug.Log(Trousers_view_im.name);
        Helmet_view = Resources.Load<Sprite>("Idle_items/Head");
        Armor_view = Resources.Load<Sprite>("Idle_items/Armor");
        Sword_view = Resources.Load<Sprite>("Idle_items/null");
        Trousers_view = Resources.Load<Sprite>("Idle_items/Trousers");
        onEquipmentChangeCallback += UpdateView;
        
    }
    void Update()
    {
        //if (something_changed)
        //{
        //    UpdateView();
        //    something_changed = false;
       // }
    }
    public void SetHelmet(Item item)
    {
        UpdateStats(Helmet, item);
        Helmet = item;
        something_changed = true;
        onEquipmentChangeCallback.Invoke();
    }
    public void SetArmor(Item item)
    {
        UpdateStats(Armor, item);
        Armor = item;
        something_changed = true;
        onEquipmentChangeCallback.Invoke();
    }
    public void SetSword(Item item)
    {
        Debug.Log(Sword);
        Debug.Log(item);
        UpdateStats(Sword, item);
        Sword = item;
        something_changed = true;
        onEquipmentChangeCallback.Invoke();
    }
    public void SetTrousers(Item item)
    {
        UpdateStats(Trousers, item);
        Trousers = item;
        something_changed = true;
        onEquipmentChangeCallback.Invoke();
    }
    public void SetBoots(Item item)
    {
        UpdateStats(Boots, item);
        Boots = item;
    }
    public void SetGloves(Item item)
    {
        UpdateStats(Gloves, item);
        Gloves = item;
    }
    public void SetNeclace(Item item)
    {
        UpdateStats(Neclace, item);
        Neclace = item;
    }
    public void UpdateView()
    {
        if(Helmet.idle_view != null) Helmet_view_im.sprite = Helmet.idle_view;
        else Helmet_view_im.sprite = Resources.Load<Sprite>("Idle_items/Head");
        if (Armor.idle_view != null) Armor_view_im.sprite = Armor.idle_view;
        else Armor_view_im.sprite = Resources.Load<Sprite>("Idle_items/Armor");
        if(Sword.idle_view != null) Sword_view_im.sprite = Sword.idle_view;
        else Sword_view_im.sprite = Resources.Load<Sprite>("Idle_items/null");
        if(Trousers.idle_view != null) Trousers_view_im.sprite = Trousers.idle_view;
        else Trousers_view_im.sprite = Resources.Load<Sprite>("Idle_items/Trousers");
    }
    public void UpdateStats(Item oldItem, Item newItem)
    {
        if(oldItem == null && newItem != null)
        {
            Damage += newItem.damage;
            Health += newItem.health;
            AbilityPower += newItem.ability_power;
            CriticalChance += newItem.critical_chance;
            Defence += newItem.defence;

        }
        else if( oldItem != null && newItem != null)
        {
         
            Damage -= oldItem.damage;
            Health -= oldItem.health;
            AbilityPower -= oldItem.ability_power;
            CriticalChance -= oldItem.critical_chance;
            Defence -= oldItem.defence;

            Damage += newItem.damage;
            Health += newItem.health;
            AbilityPower += newItem.ability_power;
            CriticalChance += newItem.critical_chance;
            Defence += newItem.defence;
        }
        else if(oldItem != null && newItem == null)
        {
            Damage -= oldItem.damage;
            Health -= oldItem.health;
            AbilityPower -= oldItem.ability_power;
            CriticalChance -= oldItem.critical_chance;
            Defence -= oldItem.defence;
        }
        stats.UpdateStatsDesc();
    }
}
