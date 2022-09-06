using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Item
{
    public int price;
    public string name;
    public int id;
    public int value;
    public string description;
    public ItemType itemType;
    public Sprite iconing;
    public Sprite idle_view;
    public string stats;

    public int damage;
    public int defence;
    public float critical_chance;
    public int health;
    public int ability_power;


    public Item()
    {
        
    }
    public Item(int val, string desc,ItemType type,int ajdi, string names,int dam, int def, float crit_chance, int health_t,int ability_pow, int pricex)
    {

        name = names;
        value = val;
        description = desc;
        itemType = type;
        id = ajdi;
        iconing = Resources.Load<Sprite>("Item_icons/" + names);
        idle_view = Resources.Load<Sprite>("Idle_items/" + names);
        damage = dam;
        defence = def;
        critical_chance = crit_chance;
        health = health_t;
        ability_power = ability_pow;
        price = pricex;

    }
    public enum ItemType
    {
        Sword,
        Armor,
        Helmet,
        Boots,
        Gloves,
        Neclace,
        Trousers,
        Consumable,
        Enhancer
    }
}
