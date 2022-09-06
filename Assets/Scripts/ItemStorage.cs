using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStorage : MonoBehaviour
{
    public static ItemStorage instance;

    //BASE OF ALL ITEMS
    //
    public List<Item> ItemBase;


    public List<Item> Swords;
    public List<Item> Armors;
    public List<Item> Helmets;
    public List<Item> Boots;
    public List<Item> Gloves;
    public List<Item> Neclaces;
    public List<Item> Trousers;
    public List<Item> Consumables;
    public List<Item> Enhancers;

    //int cena, string opis,ItemType typ_itema,int id, string nazwa,int obrazenia, int obrona, float szansa_na_kryta, int zycie,int moc_umiejetnosci
    void Awake()
    {
        instance = this;

        //SWORDS BASE
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 0, "Sword", 540, 300, 12f, 200, 30,300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 1, "Sword", 510, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 2, "Sword", 30, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 3, "Sword2", 3100, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 4, "Sword", 550, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 5, "Sword2", 590, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 6, "Sword", 580, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 7, "Sword2", 5320, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 8, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 9, "Sword2", 510, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 10, "Sword", 200, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 11, "Sword2", 300, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 12, "Sword", 1400, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 13, "Sword2", 5510, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 14, "Sword", 523, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 15, "Sword2", 503, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 16, "Sword", 5130, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 17, "Sword2", 5710, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 18, "Sword", 520, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Sword, 19, "Sword", 530, 300, 12f, 200, 30, 300));

        //ARMOR BASE

        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 20, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 21, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 22, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 23, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 24, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 25, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 26, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 27, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 28, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 29, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 30, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 31, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 32, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 33, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 34, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 35, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 36, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 37, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 38, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Armor, 39, "Sword", 500, 300, 12f, 200, 30, 300));

        //HELMETS BASE

        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 40, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 41, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 42, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 43, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 44, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 45, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 46, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 47, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 48, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 49, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 50, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 51, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 52, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 53, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 54, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 55, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 56, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 57, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 58, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Helmet, 59, "Sword", 500, 300, 12f, 200, 30, 300));

        //BOOTS BASE

        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 60, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 61, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 62, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 63, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 64, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 65, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 66, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 67, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 68, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 69, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 70, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 71, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 72, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 73, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 74, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 75, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 76, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 77, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 78, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Boots, 79, "Sword", 500, 300, 12f, 200, 30, 300));

        //GLOVES BASE

        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 80, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 81, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 82, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 83, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 84, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 85, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 86, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 87, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 88, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 89, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 90, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 91, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 92, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 93, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 94, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 95, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 96, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 97, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 98, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Gloves, 99, "Sword", 500, 300, 12f, 200, 30, 300));

        //NECLACES BASE

        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 100, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 101, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 102, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 103, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 104, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 105, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 106, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 107, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 108, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 109, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 110, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 111, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 112, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 113, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 114, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 115, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 116, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 117, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 118, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Neclace, 119, "Sword", 500, 300, 12f, 200, 30, 300));

        //TROUSERS BASE

        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 120, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 121, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 122, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 123, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 124, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 125, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 126, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 127, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 128, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 129, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 130, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 131, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 132, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 133, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 134, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 135, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 136, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 137, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 138, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Trousers, 139, "Sword", 500, 300, 12f, 200, 30, 300));

        //CONSUMABLES BASE

        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 140, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 141, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 142, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 143, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 144, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 145, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 146, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 147, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 148, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 149, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 150, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 151, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 152, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 153, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 154, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 155, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 156, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 157, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 158, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Consumable, 159, "Sword", 500, 300, 12f, 200, 30, 300));

        //ENHANCERS BASE

        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 160, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 161, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 162, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 163, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 164, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 165, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 166, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 167, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 168, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 169, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 170, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 171, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 172, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 173, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 174, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 175, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 176, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 177, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 178, "Sword", 500, 300, 12f, 200, 30, 300));
        ItemBase.Add(new Item(200, "nothing", Item.ItemType.Enhancer, 179, "Sword", 500, 300, 12f, 200, 30, 300));

        putItems();

  

    }

    private void putItems()
    {
        for (int i = 0; i < ItemBase.Count; i++)
        {
            Item.ItemType type = ItemBase[i].itemType;
            switch (type)
            {
                case Item.ItemType.Sword:
                    Swords.Add(ItemBase[i]);
                    break;
                case Item.ItemType.Armor:
                    Armors.Add(ItemBase[i]);
                    break;
                case Item.ItemType.Helmet:
                    Helmets.Add(ItemBase[i]);
                    break;
                case Item.ItemType.Boots:
                    Boots.Add(ItemBase[i]);
                    break;
                case Item.ItemType.Gloves:
                    Gloves.Add(ItemBase[i]);
                    break;
                case Item.ItemType.Neclace:
                    Neclaces.Add(ItemBase[i]);
                    break;
                case Item.ItemType.Trousers:
                    Trousers.Add(ItemBase[i]);
                    break;
                case Item.ItemType.Consumable:
                    Consumables.Add(ItemBase[i]);
                    break;
                case Item.ItemType.Enhancer:
                    Enhancers.Add(ItemBase[i]);
                    break;
            }
        }
    }
    void Start()
    {
        
        
    }

}
