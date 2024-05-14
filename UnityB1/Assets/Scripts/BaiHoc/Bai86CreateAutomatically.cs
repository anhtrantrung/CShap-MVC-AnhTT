using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bai86CreateAutomatically : MonoBehaviour
{
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(1, 1, 1);
        cube.transform.localScale = new Vector3(5,5,5);
        cube.GetComponent<Renderer>().material.color = new Color(225, 0, 0);
    }
}
