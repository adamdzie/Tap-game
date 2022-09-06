using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuUI : MonoBehaviour
{
    GameObject inventory;
    GameObject playerStats;
    GameObject equipment;
    GameObject player;
    GameObject fight;
    GameObject shop;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = GameObject.FindGameObjectWithTag("Inventory");
        playerStats = GameObject.FindGameObjectWithTag("PlayerStats");
        equipment = GameObject.FindGameObjectWithTag("Equipment");
        fight = GameObject.FindGameObjectWithTag("MenuFigh");
        shop = GameObject.FindGameObjectWithTag("Shop");
        fight.SetActive(false);
    }
    void Start()
    {
        
        equipment.SetActive(false);
        inventory.SetActive(false);
        shop.SetActive(false);
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void Inventory()
    {
        inventory.SetActive(!inventory.active);
        if (inventory.active)
        {
            equipment.SetActive(true);
            player.SetActive(true);
            playerStats.SetActive(true);
        }
        else
        {
            equipment.SetActive(false);
            shop.SetActive(false);
        }
        
        
    }
    public void Fight()
    {
        fight.SetActive(true);
    }
    public void Shop()
    {
        shop.SetActive(!shop.active);
        if (shop.active)
        {
            inventory.SetActive(true);
            equipment.SetActive(true);
            player.SetActive(false);
            playerStats.SetActive(false);
        }
        else
        {
            inventory.SetActive(false);
            equipment.SetActive(false);
            player.SetActive(true);
            playerStats.SetActive(true);

        }
    }
    
}
