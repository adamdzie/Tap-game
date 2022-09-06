using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuFight : MonoBehaviour
{
    GameObject fight;
    void Awake()
    {
        fight = GameObject.FindGameObjectWithTag("MenuFigh");
    }

    public void Back()
    {
        fight.SetActive(false);
    }
    public void Level_1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
