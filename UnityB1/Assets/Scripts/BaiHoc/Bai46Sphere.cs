using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai46Sphere : MonoBehaviour
{
    public float gravity = -12;
    
    public void SetUp(Transform playerTransform)
    {
        Vector3 gravityUp = (playerTransform.position - transform.position).normalized;
        Vector3 localUp = playerTransform.up;

        playerTransform.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion quaternion = Quaternion.FromToRotation(localUp,gravityUp)* playerTransform.rotation;
        playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation,quaternion,50f*Time.deltaTime);
    }    
}
