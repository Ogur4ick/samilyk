using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decor : MonoBehaviour
{
    public GameObject BuyButton;
    public GameObject decorButton;

    public GameObject BuyButton2;
    public GameObject decorButton2;

    public static int BuyDecor1 = 1;
    public static int BuyDecor2 = 1;

    public static int lvl;
    public static int curEXP;
    public static int Crystal;

    void Update()
    {
        if (BuyDecor1 == 1)
        {
            BuyButton.SetActive(true);
        }
        else
        {
            BuyButton.SetActive(false);
            decorButton.SetActive(true);
        }
    }

    public void BuyDecor()
    {
        if (text2.Coins >= 20)
        {

            DestroyImmediate(BuyButton);
            text2.Coins -= 20;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor1 = 2;
            PlayerPrefs.GetInt("BuyDecor1", BuyDecor1);
            decorButton.SetActive(true);
            playerstat.curEXP += 50;

        }
    }

    public void Decor2()
    {
        if (text2.Coins >= 50)
        {

            DestroyImmediate(BuyButton2);
            text2.Coins -= 50;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor2 = 2;
            PlayerPrefs.GetInt("BuyDecor2", BuyDecor2);
            decorButton2.SetActive(true);
            playerstat.curEXP += 200;

        }
    }

    void Start()
    {
        
    }

    
}
