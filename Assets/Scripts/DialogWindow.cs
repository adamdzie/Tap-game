using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activeObject()
    {
        gameObject.SetActive(true);
    }
    public void deactiveObject()
    {
        gameObject.SetActive(false);
    }

}
