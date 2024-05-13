using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai68Random : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int money = Random.Range(1, 10);
        Debug.Log(money);
    }

    
}
