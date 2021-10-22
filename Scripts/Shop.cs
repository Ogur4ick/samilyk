using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject BuyButton;
    public GameObject BuyButtonExtra;

    public GameObject BuyButton2;
    public GameObject BuyButtonExtra2;

    public GameObject HouseButton1;

    public GameObject HouseButton2;

    public GameObject BuyButton3;
    public GameObject BuyButtonExtra3;
    public GameObject HouseButton3;

    public GameObject BuyButton4;
    public GameObject BuyButtonExtra4;
    public GameObject HouseButton4;

    public static int BuyHouse1 = 1;
    public static int BuyHouse2 = 1;
    public static int BuyHouse3 = 1;
    public static int BuyHouse4 = 1;

    public static int lvl;
    public static int curEXP;
    public static int BuyHouse12;
    public static int Crystal;

    void Start()
    {
        
    }


    void Update()
    {
        if (BuyHouse1 == 1 || BuyHouse12 == 1)
        {
            BuyButton.SetActive(true);
            BuyButtonExtra.SetActive(true);
        }
        else
        {
            BuyButton.SetActive(false);
            HouseButton1.SetActive(true);
            BuyButtonExtra.SetActive(false);
        }

        if (BuyHouse2 == 1)
        {
            BuyButton2.SetActive(true);
            BuyButtonExtra2.SetActive(true);
        }
        else
        {
            BuyButton2.SetActive(false);
            HouseButton2.SetActive(true);
            BuyButtonExtra2.SetActive(false);
        }

        if (BuyHouse3 == 1)
        {
            BuyButton3.SetActive(true);
            BuyButtonExtra3.SetActive(true);
        }
        else
        {
            BuyButton3.SetActive(false);
            HouseButton3.SetActive(true);
            BuyButtonExtra3.SetActive(false);
        }

        if (BuyHouse4 == 1)
        {
            BuyButton4.SetActive(true);
            BuyButtonExtra4.SetActive(true);
        }
        else
        {
            BuyButton4.SetActive(false);
            HouseButton4.SetActive(true);
            BuyButtonExtra4.SetActive(false);
        }
    }
    public void BuyHouses()
    {
        if (text2.Coins >= 20 && playerstat.lvl >= 2)
        {

            DestroyImmediate(BuyButton);
            DestroyImmediate(BuyButtonExtra);
            text2.Coins -= 20;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyHouse1 = 2;
            PlayerPrefs.GetInt("BuyHouse1", BuyHouse1);
            HouseButton1.SetActive(true);
            playerstat.curEXP += 5;

        }
    }
    public void BuyHouses2()
    {
        if (text2.Coins >= 50 && playerstat.lvl >= 3)
        { 

            DestroyImmediate(BuyButton2);
            DestroyImmediate(BuyButtonExtra2);
            text2.Coins -= 50;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyHouse2 = 2;
            PlayerPrefs.GetInt("BuyHouse2", BuyHouse2);
            HouseButton2.SetActive(true);
            playerstat.curEXP += 7;
        }       
    }
    public void BuyHouses3()
    {
        if (text2.Coins >= 70 && playerstat.lvl >= 4)
        {

            DestroyImmediate(BuyButton3);
            DestroyImmediate(BuyButtonExtra3);
            text2.Coins -= 70;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyHouse3 = 2;
            PlayerPrefs.GetInt("BuyHouse3", BuyHouse3);
            HouseButton3.SetActive(true);
            playerstat.curEXP += 10;
        }
    }

    public void BuyHouses4()
    {
        if (text2.Coins >= 200 && playerstat.lvl >= 6)
        {

            DestroyImmediate(BuyButton4);
            DestroyImmediate(BuyButtonExtra4);
            text2.Coins -= 70;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyHouse4 = 2;
            PlayerPrefs.GetInt("BuyHouse4", BuyHouse4);
            HouseButton4.SetActive(true);
            playerstat.curEXP += 10;
        }
    }

    public void BuyHouseEmerald()
    {
        if (text2.Crystal >= 2)
        {
            DestroyImmediate(BuyButton);
            DestroyImmediate(BuyButtonExtra);
            text2.Crystal -= 2;
            PlayerPrefs.SetInt("Crystal", text2.Crystal);
            BuyHouse1 = 2;
            PlayerPrefs.GetInt("BuyHouse1", BuyHouse1);
            HouseButton1.SetActive(true);
            playerstat.curEXP += 5;
        }
    }
    public void BuyHouseEmerald2()
    {
        if (text2.Crystal >= 5)
        {
            DestroyImmediate(BuyButton2);
            DestroyImmediate(BuyButtonExtra2);
            text2.Crystal -= 5;
            PlayerPrefs.SetInt("Crystal", text2.Crystal);
            BuyHouse2 = 2;
            PlayerPrefs.GetInt("BuyHouse2", BuyHouse2);
            HouseButton2.SetActive(true);
            playerstat.curEXP += 7;

        }
    }
    public void BuyHouseEmerald3()
    {
        if (text2.Crystal >= 10)
        {
            DestroyImmediate(BuyButton3);
            DestroyImmediate(BuyButtonExtra3);
            text2.Crystal -= 10;
            PlayerPrefs.SetInt("Crystal", text2.Crystal);
            BuyHouse3 = 2;
            PlayerPrefs.GetInt("BuyHouse3", BuyHouse3);
            HouseButton3.SetActive(true);
            playerstat.curEXP += 10;

        }
    }
    public void BuyHouseEmerald4()
    {
        if (text2.Crystal >= 40)
        {
            DestroyImmediate(BuyButton4);
            DestroyImmediate(BuyButtonExtra4);
            text2.Crystal -= 10;
            PlayerPrefs.SetInt("Crystal", text2.Crystal);
            BuyHouse4 = 2;
            PlayerPrefs.GetInt("BuyHouse4", BuyHouse4);
            HouseButton4.SetActive(true);
            playerstat.curEXP += 10;

        }
    }
}