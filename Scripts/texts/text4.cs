using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text4 : MonoBehaviour
{
    public GameObject Button;
    public GameObject gameObject;
    public GameObject yes;
    public GameObject no;
    public Text TextBox3;
    public Text TextBox4;
    public Text CoinText2;
    public static int Coins;
    public static int curEXP;
    public static int EXP;
    public static int lvl;
    public static int gold;
    public Text opyt;
    //static COINS1 bablo;
    public void Go()
    {

        float x = float.Parse(TextBox3.text);
        float y = float.Parse(TextBox4.text);
        if (x == y)
        {
            text2.suc += 1;
            if (UpgradeHouse2.BuyHouse12 == 1)
            {
                if (armor.extraopyt == 2 && armor.gold == 2)
                {
                    text2.Coins += 14;
                    text2.infocoins += 14;
                    playerstat.curEXP += 4;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
                else if (armor.extraopyt == 2)
                {
                    text2.Coins += 7;
                    text2.infocoins += 7;
                    playerstat.curEXP += 4;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
                else if (armor.gold == 2)
                {
                    text2.Coins += 14;
                    text2.infocoins += 14;
                    playerstat.curEXP += 2;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
                else
                {
                    text2.Coins += 7;
                    text2.infocoins += 7;
                    playerstat.curEXP += 2;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
            }
            else if (UpgradeHouse2.BuyHouse12 == 2)
            {
                if (armor.extraopyt == 2 && armor.gold == 2)
                {
                    text2.Coins += 16;
                    text2.infocoins += 16;
                    playerstat.curEXP += 8;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
                else if (armor.extraopyt == 2)
                {
                    text2.Coins += 8;
                    text2.infocoins += 8;
                    playerstat.curEXP += 8;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
                else if (armor.gold == 2)
                {
                    text2.Coins += 16;
                    text2.infocoins += 16;
                    playerstat.curEXP += 4;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
                else
                {
                    text2.Coins += 8;
                    text2.infocoins += 8;
                    playerstat.curEXP += 4;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
            }
        }
        else
        {
            text2.fail += 1;
            gameObject.SetActive(false);
            no.SetActive(true);
        }
    }
    void Start()
    {
        CoinText2.text = "Монет:" + text2.Coins;
        opyt.text = "" + playerstat.curEXP + "/" + playerstat.EXP + "  " + playerstat.lvl;


    }
    void Update()
    {
        CoinText2.text = "Монет:" + text2.Coins;
        opyt.text = "" + playerstat.curEXP + "/" + playerstat.EXP + "  " + playerstat.lvl;

    }
    void Awake()
    {
        DontDestroyOnLoad(CoinText2);
    }
}
