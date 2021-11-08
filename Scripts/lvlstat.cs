using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlstat : MonoBehaviour
{
    public Text LvlText;
    public static int lvl;

    void Start()
    {
        LvlText.text = "Уровень " + playerstat.lvl;
    }

    // Update is called once per frame
    void Update()
    {
        LvlText.text = "Уровень " + playerstat.lvl;
    }
}
