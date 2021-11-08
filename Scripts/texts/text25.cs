using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class text25 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject TextBox2;
    public GameObject TextBox21;
    public GameObject TextBox3;

    public Text TextBox4;

    public InputField result;

    public int TheNumber;
    public int TheNumber2;
    public int TheNumber3;
    public int Result;

    // Start is called before the first frame update
    void Start()
    {
        TheNumber = Random.Range(400, 500);
        TextBox.GetComponent<Text>().text = "" + TheNumber;

        TheNumber2 = Random.Range(50, 400);
        TextBox2.GetComponent<Text>().text = "" + TheNumber2;

        TheNumber3 = Random.Range(10, 500);
        TextBox21.GetComponent<Text>().text = "" + TheNumber3;

        Result = TheNumber - TheNumber2 + TheNumber3;
        TextBox3.GetComponent<Text>().text = "" + Result;
    }

    // Update is called once per frame
    public void Next()
    {
        TextBox4.text = result.text;
    }
}