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
        textsuc.text = "���������� ��������� �������� ��������: " + text2.suc;
        textfail.text = "���������� ����������� �������� ��������: " + text2.fail;
        textbuildings.text = "���������� ��������� ������: " + Shop.Houses;
        textarmor.text = "���������� ���������� ����������: " + armor.kolvoarmora;
        textdecorations.text = "���������� ��������� ���������: " + decor.kolvodecora;
        textcoins.text = "���������� ����������� ������: " + text2.infocoins;
        textcoins2.text = "���������� ������������ ������: " + mincoins;
        textemerald.text = "���������� ���������� ����������: " + text2.infocrystal;
        textemerald2.text = "���������� ����������� ����������: " + mincrystal;


    }


    // Update is called once per frame
    void Update()
    {
        mincoins = text2.infocoins - text2.Coins;
        mincrystal = text2.infocrystal - text2.Crystal;
        textsuc.text = "���������� ��������� �������� ��������: " + text2.suc;
        textfail.text = "���������� ����������� �������� ��������: " + text2.fail;
        textbuildings.text = "���������� ��������� ������: " + Shop.Houses;
        textarmor.text = "���������� ���������� ����������: " + armor.kolvoarmora;
        textdecorations.text = "���������� ��������� ���������: " + decor.kolvodecora;
        textcoins.text = "���������� ����������� ������: " + text2.infocoins;
        textcoins2.text = "���������� ������������ ������: " + mincoins;
        textemerald.text = "���������� ���������� ����������: " + text2.infocrystal;       
        textemerald2.text = "���������� ����������� ����������: " + mincrystal;



    }
}
