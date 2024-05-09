using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZobieMove : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 5f;
    float horizontalInput;
    float verticalInput;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();    
    }

    private void FixedUpdate()
    {
        InputFromKeyboard();
        PlayerMove();
        SetAni();
    }

    public void InputFromKeyboard()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    public void PlayerMove()
    {
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        if (movement != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
        }
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    public void SetAni()
    {
        if (animator != null && horizontalInput!=0 || verticalInput !=0)
        {
            animator.SetBool("walk", true);
            animator.SetBool("idle", false);
        }
        else
        {
            animator.SetBool("idle", true);
            animator.SetBool("walk", false);

        }    
    }    
}
