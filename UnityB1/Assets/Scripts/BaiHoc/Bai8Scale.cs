using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai8Scale : MonoBehaviour
{
    private Vector3 taget;
    void Start()
    {
        SetlocalScale();
    }

   private void SetlocalScale()
    {
        taget = new Vector3(3, 3, 3);
        GameObject.Find("Cube").transform.localScale = taget;
    }    
}
