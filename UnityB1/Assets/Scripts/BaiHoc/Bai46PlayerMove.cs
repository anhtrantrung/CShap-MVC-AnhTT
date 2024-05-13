using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai46PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    Vector3 moveDir;
    public float speed = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        rb.MovePosition(transform.position+ moveDir* Time.deltaTime * speed);
    }
}
