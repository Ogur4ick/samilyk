using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
 
public class TImer : MonoBehaviour
{
    public static float timeInSecondsP;
    public static int minutsP;
    public static int secondsP;
    public Text Text;
    public Text minutes;
    public Text seconds;
 
    void Start()
    {
        Text.text = "Время, проведённое в игре: минут " + minutsP + " секунд " + secondsP;
        timeInSecondsP += Time.deltaTime;
        secondsP = (int)(timeInSecondsP % 60);
        minutsP = (int)(timeInSecondsP / 60);

        if (minutsP < 10)
        {
            minutes.text = 0 + minutsP.ToString();
            if (secondsP < 10)
            {
                seconds.text = 0 + secondsP.ToString();
            }
            else
            {
                seconds.text = secondsP.ToString();
            }
        }
        else
        {
            minutes.text = 0 + minutsP.ToString();
            if (secondsP < 10)
            {
                seconds.text = 0 + secondsP.ToString();
            }
            else
            {
                seconds.text = secondsP.ToString();
            }
        }
    }
    void Update()
    {
        Text.text = "Время, проведённое в игре: " + minutsP + " минут  " + secondsP + " секунд ";
        timeInSecondsP += Time.deltaTime;
        secondsP = (int)(timeInSecondsP % 60);
        minutsP = (int)(timeInSecondsP / 60);

        if (minutsP < 10)
        {
            minutes.text = 0 + minutsP.ToString();
            if (secondsP < 10)
            {
                seconds.text = 0 + secondsP.ToString();
            }
            else
            {
                seconds.text = secondsP.ToString();
            }
        }
        else
        {
            minutes.text = 0 + minutsP.ToString();
            if (secondsP < 10)
            {
                seconds.text = 0 + secondsP.ToString();
            }
            else
            {
                seconds.text = secondsP.ToString();
            }
        }



    }
    public void Timerrr()
    {
        timeInSecondsP += Time.deltaTime;
        secondsP = (int)(timeInSecondsP % 60);
        minutsP = (int)(timeInSecondsP / 60);

        if (minutsP < 10)
        {
            minutes.text = 0 + minutsP.ToString();
            if (secondsP < 10)
            {
                seconds.text = 0 + secondsP.ToString();
            }
            else
            {
                seconds.text = secondsP.ToString();
            }
        }
        else
        {
            minutes.text = 0 + minutsP.ToString();
            if (secondsP < 10)
            {
                seconds.text = 0 + secondsP.ToString();
            }
            else
            {
                seconds.text = secondsP.ToString();
            }
        }
    }
}
