using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade2 : MonoBehaviour
{
    public GameObject UpgradeMenu2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenUpgradeMenu2()
    {
        UpgradeMenu2.SetActive(true);
    }

    public void CloseUpgradeMenu2()
    {
        UpgradeMenu2.SetActive(false);
    }
}
