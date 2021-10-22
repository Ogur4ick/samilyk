using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text5 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject TextBox2;
    public GameObject TextBox3;

    public Text TextBox4;

    public InputField result;

    public int TheNumber;
    public int TheNumber2;
    public int Result;



    void Start()
    {
        TheNumber = Random.Range(5, 10);
        TextBox.GetComponent<Text>().text = "" + TheNumber;

        TheNumber2 = Random.Range(1, 5);
        TextBox2.GetComponent<Text>().text = "" + TheNumber2;

        Result = TheNumber - TheNumber2;
        TextBox3.GetComponent<Text>().text = "" + Result;
    }
    public void Next()
    {
        TextBox4.text = result.text;


    }
}

