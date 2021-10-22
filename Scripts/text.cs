using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class text : MonoBehaviour
{
    

    public GameObject TextBox;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public GameObject TextBox5;

    public Text TextBox4;

    public InputField result;

    public int TheNumber;
    public int TheNumber2;
    public int Result;



    void Start()
    {
        TheNumber = Random.Range(1, 10);
        TextBox.GetComponent<Text>().text = "" + TheNumber;

        TheNumber2 = Random.Range(1, 10);
        TextBox2.GetComponent<Text>().text = "" + TheNumber2;

        Result = TheNumber + TheNumber2;
        TextBox3.GetComponent<Text>().text = "" + Result;
    }
    public void Next()
    {
        TextBox4.text = result.text;

       
    }
}
