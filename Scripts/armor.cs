using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armor : MonoBehaviour
{
    public GameObject BuyButton;
    public GameObject decorButton;
    public GameObject obmenButton;

    public GameObject BuyButton2;
    public GameObject decorButton2;

    public GameObject BuyButton3;
    public GameObject decorButton3;

    public GameObject BuyButton4;
    public GameObject decorButton4;

    public GameObject BuyButton5;
    public GameObject decorButton5;

    public GameObject BuyButton6;
    public GameObject decorButton6;
    public GameObject decorButton61;

    public GameObject BuyButton7;
    public GameObject decorButton7;
    public GameObject decorButton71;

    public static int BuyDecor1 = 1;
    public static int BuyDecor2 = 1;
    public static int BuyDecor3 = 1;
    public static int BuyDecor4 = 1;
    public static int BuyDecor5 = 1;
    public static int BuyDecor6 = 1;
    public static int BuyDecor7 = 1;

    public static int kolvoarmora = 0;

    public static int gold = 1;
    public static int extraopyt = 1;

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
            obmenButton.SetActive(true);
        }
        if (BuyDecor2 == 1)
        {
            BuyButton2.SetActive(true);
        }
        else
        {
            BuyButton2.SetActive(false);
            decorButton2.SetActive(true);
        }
        if (BuyDecor3 == 1)
        {
            BuyButton3.SetActive(true);
        }
        else
        {
            BuyButton3.SetActive(false);
            decorButton3.SetActive(true);
        }
        if (BuyDecor4 == 1)
        {
            BuyButton4.SetActive(true);
        }
        else
        {
            BuyButton4.SetActive(false);
            decorButton4.SetActive(true);
        }
        if (BuyDecor5 == 1)
        {
            BuyButton5.SetActive(true);
        }
        else
        {
            BuyButton5.SetActive(false);
            decorButton5.SetActive(true);
        }
        if (BuyDecor6 == 1)
        {
            BuyButton6.SetActive(true);
        }
        else
        {
            BuyButton6.SetActive(false);
            decorButton6.SetActive(true);
            decorButton61.SetActive(true);
        }
        if (BuyDecor7 == 1)
        {
            BuyButton7.SetActive(true);
            decorButton71.SetActive(false);
        }
        else
        {
            BuyButton7.SetActive(false);
            decorButton7.SetActive(true);
            decorButton71.SetActive(true);
        }
    }

    public void BuyDecor()
    {
        if (text2.Coins >= 1500)
        {

            DestroyImmediate(BuyButton);
            text2.Coins -= 1500;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor1 = 2;
            PlayerPrefs.GetInt("BuyDecor1", BuyDecor1);
            decorButton.SetActive(true);
            obmenButton.SetActive(true);
            kolvoarmora += 1;

        }
    }

    public void Decor2()
    {
        if (text2.Coins >= 1750)
        {

            DestroyImmediate(BuyButton2);
            text2.Coins -= 1750;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor2 = 2;
            extraopyt = 2;
            PlayerPrefs.GetInt("BuyDecor2", BuyDecor2);
            decorButton2.SetActive(true);
            kolvoarmora += 1;

        }
    }

    public void Decor3()
    {
        if (text2.Coins >= 2000)
        {

            DestroyImmediate(BuyButton3);
            text2.Coins -= 2000;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor3 = 2;
            gold = 2;
            PlayerPrefs.GetInt("BuyDecor3", BuyDecor3);
            decorButton3.SetActive(true);
            kolvoarmora += 1;

        }
    }

    public void Decor4()
    {
        if (text2.Coins >= 500)
        {

            DestroyImmediate(BuyButton4);
            text2.Coins -= 500;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor4 = 2;
            PlayerPrefs.GetInt("BuyDecor4", BuyDecor4);
            decorButton4.SetActive(true);
            playerstat.curEXP += 200000;
            kolvoarmora += 1;

        }
    }

    public void Decor5()
    {
        if (text2.Coins >= 100)
        {

            DestroyImmediate(BuyButton5);
            text2.Coins -= 100;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor5 = 2;
            PlayerPrefs.GetInt("BuyDecor5", BuyDecor5);
            decorButton5.SetActive(true);
            kolvoarmora += 1;

        }
    }

    public void Decor6()
    {
        if (text2.Coins >= 2000)
        {

            DestroyImmediate(BuyButton6);
            text2.Coins -= 2000;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor6 = 2;
            PlayerPrefs.GetInt("BuyDecor6", BuyDecor6);
            decorButton6.SetActive(true);
            decorButton61.SetActive(true);
            kolvoarmora += 1;

        }
    }

    public void Decor7()
    {
        if (text2.Coins >= 2000)
        {

            DestroyImmediate(BuyButton7);
            text2.Coins -= 2000;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyDecor7 = 2;
            PlayerPrefs.GetInt("BuyDecor7", BuyDecor7);
            decorButton7.SetActive(true);
            decorButton71.SetActive(true);
            kolvoarmora += 1;

        }
    }

    void Start()
    {

    }


}