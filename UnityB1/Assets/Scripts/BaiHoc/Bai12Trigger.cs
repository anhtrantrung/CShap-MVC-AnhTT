using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai12Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter " + other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit " + other.gameObject.name);
    }
}
