using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    [SerializeField] Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void LateUpdate()
    {
        MoveToTaget();
    }

    public void MoveToTaget( )
    {
        transform.position = player.position + offset;
    }    

}
