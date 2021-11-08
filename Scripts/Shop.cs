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

    public GameObject BuyButton5;
    public GameObject BuyButtonExtra5;
    public GameObject HouseButton5;

    public GameObject BuyButton6;
    public GameObject BuyButtonExtra6;
    public GameObject HouseButton6;

    public GameObject BuyButton7;
    public GameObject BuyButtonExtra7;
    public GameObject HouseButton7;

    public static int BuyHouse1 = 1;
    public static int BuyHouse2 = 1;
    public static int BuyHouse3 = 1;
    public static int BuyHouse4 = 1;
    public static int BuyHouse5 = 1;
    public static int BuyHouse6 = 1;
    public static int BuyHouse7 = 1;

    public static int Houses = 0;

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
        if (BuyHouse5 == 1)
        {
            BuyButton5.SetActive(true);
            BuyButtonExtra5.SetActive(true);
        }
        else
        {
            BuyButton5.SetActive(false);
            HouseButton5.SetActive(true);
            BuyButtonExtra5.SetActive(false);
        }
        if (BuyHouse6 == 1)
        {
            BuyButton6.SetActive(true);
            BuyButtonExtra6.SetActive(true);
        }
        else
        {
            BuyButton6.SetActive(false);
            HouseButton6.SetActive(true);
            BuyButtonExtra6.SetActive(false);
        }
        if (BuyHouse7 == 1)
        {
            BuyButton7.SetActive(true);
            BuyButtonExtra7.SetActive(true);
        }
        else
        {
            BuyButton7.SetActive(false);
            HouseButton7.SetActive(true);
            BuyButtonExtra7.SetActive(false);
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
            Houses += 1;

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
            Houses += 1;
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
            Houses += 1;
        }
    }

    public void BuyHouses4()
    {
        if (text2.Coins >= 200 && playerstat.lvl >= 6)
        {

            DestroyImmediate(BuyButton4);
            DestroyImmediate(BuyButtonExtra4);
            text2.Coins -= 200;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyHouse4 = 2;
            PlayerPrefs.GetInt("BuyHouse4", BuyHouse4);
            HouseButton4.SetActive(true);
            playerstat.curEXP += 10;
            Houses += 1;
        }
    }
    public void BuyHouses5()
    {
        if (text2.Coins >= 400 && playerstat.lvl >= 6)
        {

            DestroyImmediate(BuyButton5);
            DestroyImmediate(BuyButtonExtra5);
            text2.Coins -= 400;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyHouse5 = 2;
            PlayerPrefs.GetInt("BuyHouse5", BuyHouse5);
            HouseButton5.SetActive(true);
            playerstat.curEXP += 10;
            Houses += 1;
        }
    }

    public void BuyHouses6()
    {
        if (text2.Coins >= 600 && playerstat.lvl >= 7)
        {

            DestroyImmediate(BuyButton6);
            DestroyImmediate(BuyButtonExtra6);
            text2.Coins -= 600;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyHouse6 = 2;
            PlayerPrefs.GetInt("BuyHouse6", BuyHouse6);
            HouseButton6.SetActive(true);
            playerstat.curEXP += 10;
            Houses += 1;
        }
    }
    public void BuyHouses7()
    {
        if (text2.Coins >= 1000 && playerstat.lvl >= 8)
        {

            DestroyImmediate(BuyButton7);
            DestroyImmediate(BuyButtonExtra7);
            text2.Coins -= 1000;
            PlayerPrefs.SetInt("Coins", text2.Coins);
            BuyHouse7 = 2;
            PlayerPrefs.GetInt("BuyHouse7", BuyHouse7);
            HouseButton7.SetActive(true);
            playerstat.curEXP += 10;
            Houses += 1;
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
            Houses += 1;
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
            Houses += 1;

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
            Houses += 1;

        }
    }
    public void BuyHouseEmerald4()
    {
        if (text2.Crystal >= 40)
        {
            DestroyImmediate(BuyButton4);
            DestroyImmediate(BuyButtonExtra4);
            text2.Crystal -= 40;
            PlayerPrefs.SetInt("Crystal", text2.Crystal);
            BuyHouse4 = 2;
            PlayerPrefs.GetInt("BuyHouse4", BuyHouse4);
            HouseButton4.SetActive(true);
            playerstat.curEXP += 10;
            Houses += 1;

        }
    }
    public void BuyHouseEmerald5()
    {
        if (text2.Crystal >= 40)
        {
            DestroyImmediate(BuyButton5);
            DestroyImmediate(BuyButtonExtra5);
            text2.Crystal -= 40;
            PlayerPrefs.SetInt("Crystal", text2.Crystal);
            BuyHouse5 = 2;
            PlayerPrefs.GetInt("BuyHouse5", BuyHouse5);
            HouseButton5.SetActive(true);
            playerstat.curEXP += 10;
            Houses += 1;

        }
    }
    public void BuyHouseEmerald6()
    {
        if (text2.Crystal >= 60)
        {
            DestroyImmediate(BuyButton6);
            DestroyImmediate(BuyButtonExtra6);
            text2.Crystal -= 40;
            PlayerPrefs.SetInt("Crystal", text2.Crystal);
            BuyHouse6 = 2;
            PlayerPrefs.GetInt("BuyHouse6", BuyHouse6);
            HouseButton6.SetActive(true);
            playerstat.curEXP += 10;
            Houses += 1;

        }
    }
    public void BuyHouseEmerald7()
    {
        if (text2.Crystal >= 100)
        {
            DestroyImmediate(BuyButton7);
            DestroyImmediate(BuyButtonExtra7);
            text2.Crystal -= 40;
            PlayerPrefs.SetInt("Crystal", text2.Crystal);
            BuyHouse7 = 2;
            PlayerPrefs.GetInt("BuyHouse7", BuyHouse7);
            HouseButton7.SetActive(true);
            playerstat.curEXP += 10;
            Houses += 1;

        }
    }
}