using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class achieve : MonoBehaviour
{
    public GameObject Button;
    public GameObject achievement1;

    public GameObject Button2;
    public GameObject achievement2;
    
    public GameObject Button3;
    public GameObject achievement3;

    public GameObject Button4;
    public GameObject achievement4;

    public GameObject Button5;
    public GameObject achievement5;

    public GameObject Button6;
    public GameObject achievement6;

    public GameObject Button7;
    public GameObject achievement7;

    public GameObject Button8;
    public GameObject achievement8;

    public GameObject Button9;
    public GameObject achievement9;


    public static int ch1 = 1;
    public static int ch2 = 1;
    public static int ch3 = 1;
    public static int ch4 = 1;
    public static int ch5 = 1;
    public static int ch6 = 1;
    public static int ch7 = 1;
    public static int ch8 = 1;
    public static int ch9 = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (text2.suc >= 10 && ch1 == 1)
        {
            Button.SetActive(true);
        }
        else
        {
            Button.SetActive(false);
        }
        if (ch1 == 1)
        {
            achievement1.SetActive(true);
        }
        else
        {
            achievement1.SetActive(false);
        }

        if (text2.suc >= 50 && ch2 == 1)
        {
            Button2.SetActive(true);
        }
        else
        {
            Button2.SetActive(false);
        }
        if (ch2 == 1)
        {
            achievement2.SetActive(true);
        }
        else
        {
            achievement2.SetActive(false);
        }

        if (text2.suc >= 100 && ch3 == 1)
        {
            Button3.SetActive(true);
        }
        else
        {
            Button3.SetActive(false);
        }
        if (ch3 == 1)
        {
            achievement3.SetActive(true);
        }
        else
        {
            achievement3.SetActive(false);
        }

        if (Shop.Houses >= 1 && ch4 == 1)
        {
            Button4.SetActive(true);
        }
        else
        {
            Button4.SetActive(false);
        }
        if (ch4 == 1)
        {
            achievement4.SetActive(true);
        }
        else
        {
            achievement4.SetActive(false);
        }

        if (Shop.Houses >= 4 && ch5 == 1)
        {
            Button5.SetActive(true);
        }
        else
        {
            Button5.SetActive(false);
        }
        if (ch5 == 1)
        {
            achievement5.SetActive(true);
        }
        else
        {
            achievement5.SetActive(false);
        }

        if (Shop.Houses >= 7 && ch6 == 1)
        {
            Button6.SetActive(true);
        }
        else
        {
            Button6.SetActive(false);
        }
        if (ch6 == 1)
        {
            achievement6.SetActive(true);
        }
        else
        {
            achievement6.SetActive(false);
        }
        if (armor.kolvoarmora >= 1 && ch7 == 1)
        {
            Button7.SetActive(true);
        }
        else
        {
            Button7.SetActive(false);
        }
        if (ch7 == 1)
        {
            achievement7.SetActive(true);
        }
        else
        {
            achievement7.SetActive(false);
        }

        if (decor.kolvodecora >= 7 && ch8 == 1)
        {
            Button8.SetActive(true);
        }
        else
        {
            Button8.SetActive(false);
        }
        if (ch8 == 1)
        {
            achievement8.SetActive(true);
        }
        else
        {
            achievement8.SetActive(false);
        }

        if (text2.fail >= 1 && ch9 == 1)
        {
            Button9.SetActive(true);
        }
        else
        {
            Button9.SetActive(false);
        }
        if (ch9 == 1)
        {
            achievement9.SetActive(true);
        }
        else
        {
            achievement9.SetActive(false);
        }

    }
    public void Ach1()
    {
        text2.Coins += 50;
        text2.infocoins += 50;
        Button.SetActive(false);
        achievement1.SetActive(false);
        ch1 = 2;
    }

    public void Ach2()
    {
        text2.Coins += 500;
        text2.infocoins += 500;
        Button2.SetActive(false);
        achievement2.SetActive(false);
        ch2 = 2;
    }

    public void Ach3()
    {
        text2.Coins += 1500;
        text2.infocoins += 1500;
        Button3.SetActive(false);
        achievement3.SetActive(false);
        ch3 = 2;
    }

    public void Ach4()
    {
        text2.Crystal += 5;
        text2.infocrystal += 5;
        Button4.SetActive(false);
        achievement4.SetActive(false);
        ch4 = 2;
    }

    public void Ach5()
    {
        text2.Crystal += 20;
        text2.infocrystal += 20;
        Button5.SetActive(false);
        achievement5.SetActive(false);
        ch5 = 2;
    }

    public void Ach6()
    {
        text2.Crystal += 50;
        text2.infocrystal += 50;
        Button6.SetActive(false);
        achievement6.SetActive(false);
        ch6 = 2;
    }

    public void Ach7()
    {
        text2.Crystal += 3;
        text2.infocrystal += 3;
        Button7.SetActive(false);
        achievement7.SetActive(false);
        ch7 = 2;
    }

    public void Ach8()
    {
        text2.Crystal += 10;
        text2.infocrystal += 10;
        Button8.SetActive(false);
        achievement8.SetActive(false);
        ch8 = 2;
    }

    public void Ach9()
    {
        text2.Crystal += 2;
        text2.infocrystal += 2;
        Button9.SetActive(false);
        achievement9.SetActive(false);
        ch9 = 2;
    }
}
