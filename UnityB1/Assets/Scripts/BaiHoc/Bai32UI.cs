using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bai32UI : MonoBehaviour
{
    public Text helloTxt;
    void Start()
    {
        SetTxt();
    }

    public void SetTxt()
    {
        if (helloTxt != null)
        {
            helloTxt.text = "Hello";
        }
    }
}
