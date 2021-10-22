using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeHouse : MonoBehaviour
{
    public GameObject Info1;
    public GameObject Info2;
    public GameObject HouseButton1;
    public GameObject HouseButton2;
    public GameObject HouseButton3;
    public GameObject HouseButton4;
    public GameObject Button1;
    public static int BuyHouse11 = 1;
    

    void Update()
    {
        if (BuyHouse11 == 1)
        {
            Button1.SetActive(true);
            HouseButton1.SetActive(true);
            HouseButton2.SetActive(false);
            Info1.SetActive(true);
            Info2.SetActive(false);
            HouseButton3.SetActive(true);
            HouseButton4.SetActive(false);
        }
        else
        {
            Button1.SetActive(false);
            HouseButton1.SetActive(false);
            HouseButton2.SetActive(true);
            Info1.SetActive(false);
            Info2.SetActive(true);
            HouseButton3.SetActive(false);
            HouseButton4.SetActive(true);
        }  
    }
    public void Trade()
    {
        if (text2.Coins >= 50)
        {
            BuyHouse11 = 2;
            text2.Coins -= 50;
            playerstat.curEXP += 5;
        }    
        
    }
}
