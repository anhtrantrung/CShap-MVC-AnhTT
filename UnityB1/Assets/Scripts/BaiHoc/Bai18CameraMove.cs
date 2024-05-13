using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bai18CameraMove : MonoBehaviour
{
    GameObject player;
    Vector3 camOffset;
    void Start()
    {
        player = GameObject.Find("Player");
        camOffset = new Vector3(0,4,-10);
    }

    void Update()
    {
        CameraMove();
    }

    public void CameraMove()
    {
        transform.position = player.transform.position + camOffset;
    }    
}
