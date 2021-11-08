using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class text19 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject TextBox2;
    public GameObject TextBox3;

    public Text TextBox4;

    public InputField result;

    public int TheNumber;
    public int TheNumber2;
    public int Result;

    // Start is called before the first frame update
    void Start()
    {
        TheNumber = Random.Range(2, 30);
        TextBox.GetComponent<Text>().text = "" + TheNumber;

        TheNumber2 = Random.Range(2, 3);
        TextBox2.GetComponent<Text>().text = "" + TheNumber2;

        if (TheNumber2 == 2)
        {
            Result = TheNumber * TheNumber;
        }
        if (TheNumber2 == 3)
        {
            Result = TheNumber * TheNumber * TheNumber;
        }
        
        TextBox3.GetComponent<Text>().text = "" + Result;
    }

    // Update is called once per frame
    public void Next()
    {
        TextBox4.text = result.text;
    }
}
