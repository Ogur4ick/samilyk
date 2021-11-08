using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class text2 : MonoBehaviour
{
    public GameObject Button;
    public GameObject gameObject;
    public GameObject yes;
    public GameObject no;
    public Text TextBox3;
    public Text TextBox4;
    public Text CoinText;
    public Text CrystalText;
    public static int Coins = 0;
    public static int infocoins = 0;
    public static int Crystal = 0;
    public static int infocrystal = 0;
    public static int curEXP;
    public static int EXP;
    public static int lvl;
    public static int gold;
    public static int suc;
    public static int fail;
    public Text opyt;
    public static int BuyHouse11;


    public void Go()
    {
        
        float x = float.Parse(TextBox3.text);
        float y = float.Parse(TextBox4.text);
        if (x == y)
        {
            suc += 1;
            if  (UpgradeHouse.BuyHouse11 == 1)
            {
                if (armor.extraopyt == 2 && armor.gold == 2)
                {
                        Coins += 10;
                        infocoins += 10;
                        playerstat.curEXP += 4;
                        yes.SetActive(true);
                        gameObject.SetActive(false);
                }
                else if (armor.extraopyt == 2)
                { 
                        Coins += 5;
                        infocoins += 5;
                        playerstat.curEXP += 4;
                        yes.SetActive(true);
                        gameObject.SetActive(false);
                }
                else if (armor.gold == 2)
                {
                    Coins += 10;
                    infocoins += 10;
                    playerstat.curEXP += 2;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
                else
                {
                    Coins += 5000;
                    infocoins += 5;
                    playerstat.curEXP += 2;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                }
            }
            else if (UpgradeHouse.BuyHouse11 == 2)
            {
                if (armor.extraopyt == 2 && armor.gold == 2)
                {
                    Coins += 14;
                    infocoins += 14;
                    playerstat.curEXP += 10;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                    infocrystal += 1;
                    Crystal += 1;

                }
                else if (armor.extraopyt == 2)
                {
                    Coins += 7;
                    infocoins += 7;
                    playerstat.curEXP += 10;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                    infocrystal += 1;
                    Crystal += 1;

                }
                else if (armor.gold == 2)
                {
                    Coins += 14;
                    infocoins += 14;
                    playerstat.curEXP += 5;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                    infocrystal += 1;
                    Crystal += 1;

                }
                else
                {
                    Coins += 7;
                    infocoins += 7;
                    playerstat.curEXP += 5;
                    yes.SetActive(true);
                    gameObject.SetActive(false);
                    Crystal += 1;
                    infocrystal += 1;
                }
            }          
        }      
        else
        {
            fail += 1;
            gameObject.SetActive(false);
            no.SetActive(true);
        }
        
    }
    void Start()
    {
        CoinText.text = "Монет: " + Coins;
        opyt.text = "" + playerstat.curEXP + "/" + playerstat.EXP + "  " + playerstat.lvl;
        CrystalText.text = "" + Crystal;

    }
    void Update()
    {
        CoinText.text = "Монет: " + Coins;
        opyt.text = "опыта: " + playerstat.curEXP + "/" + playerstat.EXP + " уровень: " + playerstat.lvl;
        CrystalText.text = "" + Crystal;
    }
    
    
}
