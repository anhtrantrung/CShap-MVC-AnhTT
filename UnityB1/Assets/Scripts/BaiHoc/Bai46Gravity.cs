using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai46Gravity : MonoBehaviour
{
    public Bai46Sphere bai46Sphere;
    Transform playerTransform;

    void Start()
    {
        GetComponent<Rigidbody>().useGravity= false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        playerTransform = transform;
    }

    private void FixedUpdate()
    {
        if (playerTransform != null)
        {
            bai46Sphere.SetUp(playerTransform);
        }
    }
}
