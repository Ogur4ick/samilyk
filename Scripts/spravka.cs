using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spravka : MonoBehaviour
{
    public Text textsuc;
    public Text textfail;
    public Text textbuildings;
    public Text textarmor;
    public Text textdecorations;
   // public Text texttime;
    public Text textcoins;
    public Text textemerald;
    public Text textcoins2;
    public Text textemerald2;
    public static int mincoins;
    public static int mincrystal;

    public float timeStart;
    void Start()
    {
        mincoins = text2.infocoins - text2.Coins;
        mincrystal = text2.infocrystal - text2.Crystal;
        textsuc.text = "Количество правильно решённых примеров: " + text2.suc;
        textfail.text = "Количество неправильно решённых примеров: " + text2.fail;
        textbuildings.text = "Количество купленных зданий: " + Shop.Houses;
        textarmor.text = "Количество купленного снаряжения: " + armor.kolvoarmora;
        textdecorations.text = "Количество купленных декораций: " + decor.kolvodecora;
        textcoins.text = "Количество полученного золота: " + text2.infocoins;
        textcoins2.text = "Количество потраченного золота: " + mincoins;
        textemerald.text = "Количество полученных кристаллов: " + text2.infocrystal;
        textemerald2.text = "Количество потраченных кристаллов: " + mincrystal;


    }


    // Update is called once per frame
    void Update()
    {
        mincoins = text2.infocoins - text2.Coins;
        mincrystal = text2.infocrystal - text2.Crystal;
        textsuc.text = "Количество правильно решённых примеров: " + text2.suc;
        textfail.text = "Количество неправильно решённых примеров: " + text2.fail;
        textbuildings.text = "Количество купленных зданий: " + Shop.Houses;
        textarmor.text = "Количество купленного снаряжения: " + armor.kolvoarmora;
        textdecorations.text = "Количество купленных декораций: " + decor.kolvodecora;
        textcoins.text = "Количество полученного золота: " + text2.infocoins;
        textcoins2.text = "Количество потраченного золота: " + mincoins;
        textemerald.text = "Количество полученных кристаллов: " + text2.infocrystal;       
        textemerald2.text = "Количество потраченных кристаллов: " + mincrystal;



    }
}
