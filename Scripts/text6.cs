using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text6 : MonoBehaviour
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
    public Text opyt;
    //static COINS1 bablo;
    public void Go()
    {

        float x = float.Parse(TextBox3.text);
        float y = float.Parse(TextBox4.text);
        if (x == y)
        {
            text2.Coins += 5;
            playerstat.curEXP += 2;
            yes.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
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