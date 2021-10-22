using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade3 : MonoBehaviour
{
    public GameObject UpgradeMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenUpgradeMenu()
    {
        UpgradeMenu.SetActive(true);
    }

    public void CloseUpgradeMenu()
    {
        UpgradeMenu.SetActive(false);
    }
}
