using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traiding1 : MonoBehaviour
{
    public static int curEXP;
    public static int EXP;
    public static int lvl;
    public static int Coins;
    public static int Crystal;

    public void Trade3()
    {
        if (text2.Coins >= 500)
        {
            text2.Coins -= 100;
            playerstat.curEXP += 100;
        }
    }
    public void Trade()
    {
        if (text2.Coins >= 50)
        {
            text2.Coins -= 50;
            playerstat.curEXP += 10;
        }
    }
    public void Trade2()
    {
        if (text2.Coins >= 5)
        {
            text2.Coins -= 5;
            playerstat.curEXP += 1;
        }
    }
    public void Trade4()
    {
        if (text2.Crystal >= 5)
        {
            text2.Crystal -= 5;
            text2.Coins += 100;
        }
    }
    public void Trade5()
    {
        if (text2.Crystal >= 1)
        {
            text2.Crystal -= 1;
            text2.Coins += 20;
        }
    }
}
