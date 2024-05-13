using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai52Rotate : MonoBehaviour
{
    public float speed = 10f;
    
    void Update()
    {
        SetRotate();
        
    }

    public void SetRotate()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }    
}
