using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStats : MonoBehaviour
{
    Player player;
    Text playerStats;
    public static PlayerStats instance;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerStats = GetComponent<Text>();
        playerStats.text = "Health: " + player.Health+ "\n"
        + "Damage: " + player.Damage + "\n" + "Defense: " + player.Defence + "\n" + "Ability Power: " + player.AbilityPower
        + "\n" + "Critical Chance: " + player.CriticalChance + "%";
    }

    public void UpdateStatsDesc()
    {
       
       playerStats.text = "Health: " + player.Health + "\n"
       + "Damage: " + player.Damage + "\n" + "Defense: " + player.Defence + "\n" + "Ability Power: " + player.AbilityPower
       + "\n" + "Critical Chance: " + player.CriticalChance + "%";
    }
   

}
