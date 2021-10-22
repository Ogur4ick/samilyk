using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class change : MonoBehaviour
{
    public Text TextBox3;
    public Text TextBox4;

    public Sprite pic1;
    public Sprite pic2;
    private SpriteRenderer spriteRender;
    
    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    public void Change()
    {
        float x = float.Parse(TextBox3.text);
        float y = float.Parse(TextBox4.text);
        if (x == y)
        {
            spriteRender.sprite = pic1;
        }
        else
        {
            spriteRender.sprite = pic2;
        }
    }

}
