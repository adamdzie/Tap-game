using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResourcesScript : MonoBehaviour
{
    public delegate void OnGoldChange();
    public OnGoldChange onGoldChangeCallback;
    public static ResourcesScript instance;
    Text gold;
    Player player;
    // Start is called before the first frame update

    void Awake()
    {
        gold = gameObject.transform.GetChild(0).transform.GetComponent<Text>();
        instance = this;
    }
    void Start()
    {
        onGoldChangeCallback += updateGold;
        player = Player.instance;
        gold.text = player.Gold.ToString();

    }

    // Update is called once per frame
    public void updateGold()
    {
        gold.text = player.Gold.ToString();
    }
}
