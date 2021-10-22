using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    public GameObject Info1;
    void Start()
    {
        Info1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenInfo()
    {
        Info1.SetActive(true);
    }

    public void CloseInfo()
    {
        Info1.SetActive(false);
    }
}
