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
    public static int Crystal = 0;
    public static int curEXP;
    public static int EXP;
    public static int lvl;
    public Text opyt;
    public static int BuyHouse11;


    public void Go()
    {
        
        float x = float.Parse(TextBox3.text);
        float y = float.Parse(TextBox4.text);
        if (x == y)
        {
            if  (UpgradeHouse.BuyHouse11 == 1)
            {
                Coins += 100;
                playerstat.curEXP += 2;
                yes.SetActive(true);
                gameObject.SetActive(false);
            }
            else if (UpgradeHouse.BuyHouse11 == 2)
            {
                Coins += 200;
                playerstat.curEXP += 5;
                Crystal += 50;
                yes.SetActive(true);
                gameObject.SetActive(false);
            }          
        }      
        else
        {
            gameObject.SetActive(false);
            no.SetActive(true);
        }
        
    }
    void Start()
    {
        CoinText.text = "Монет:" + Coins;
        opyt.text = "" + playerstat.curEXP + "/" + playerstat.EXP + "  " + playerstat.lvl;
        CrystalText.text = "" + Crystal;

    }
    void Update()
    {
        CoinText.text = "Монет:" + Coins;
        opyt.text = "опыта: " + playerstat.curEXP + "/" + playerstat.EXP + " уровень: " + playerstat.lvl;
        CrystalText.text = "" + Crystal;
    }
    void Awake()
    {
        DontDestroyOnLoad(CoinText);
        DontDestroyOnLoad(opyt);
    }
    
}
