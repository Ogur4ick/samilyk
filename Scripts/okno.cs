using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okno : MonoBehaviour
{
    public bool Buy;
    public GameObject Info1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Info12()
    {
        
        if (Buy == true)
        {
            Info1.SetActive(true);
            Buy = false;
        }
        else
        {
            Info1.SetActive(false);
            Buy = true;
        }
    }
}
