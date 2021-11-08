using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nachalo : MonoBehaviour
{
    public GameObject nachalo1;
    public GameObject nachalo2;
    public GameObject nachalo3;
    public GameObject nachalo4;
    public GameObject nachalo5;
    public GameObject nachalo6;
    public GameObject nachalo7;

    public static int ob1;
    public static int ob2;
    public static int ob3;
    public static int ob4;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ob1 == 2)
        {
            nachalo3.SetActive(false);
            nachalo4.SetActive(true);
        }
        if (ob2 == 2)
        {
            nachalo5.SetActive(false);
        }
        if (ob4 == 2)
        {
            nachalo7.SetActive(false);
        }


    }
    public void Exp1()
    {
        nachalo1.SetActive(false);
        nachalo2.SetActive(true);
    }

    public void Exp2()
    {
        nachalo2.SetActive(false);
        nachalo3.SetActive(true);
        nachalo4.SetActive(true);
        ob1 = 1;
    }
    public void Exp3()
    {
        ob1 = 2;
        nachalo3.SetActive(false);
        
    }
    public void Exp4()
    {
        nachalo5.SetActive(false);
        ob2 = 2;
    }
    public void Exp5()
    {
        nachalo6.SetActive(false);
        ob3 = 2;
    }
    public void Exp6()
    {
        nachalo7.SetActive(false);
        ob4 = 2;
    }
}
