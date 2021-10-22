using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyBuildings : MonoBehaviour
{
    public GameObject ShopBuildings;
    void Start()
    {
        
    }

    public void OpenShopBuildings()
    {
        ShopBuildings.SetActive(true);
    }

    public void CloseShopBuildings()
    {
        ShopBuildings.SetActive(false);
    }
}
