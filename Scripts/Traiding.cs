using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traiding : MonoBehaviour
{
    public GameObject TraidingMenu;
    void Start()
    {
       
    }

    public void OpenTraidingMenu()
    {
        TraidingMenu.SetActive(true);
    }

    public void CloseTraidingMenu()
    {
        TraidingMenu.SetActive(false);
    }
}
