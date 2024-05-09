using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai17Keyboard : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 2f;
    float horizontalInput;
    float verticalInput;
    Rigidbody rb;

    void Update()
    {
        InputFromKeyboard();
        PlayerMove();
    }

    public void InputFromKeyboard()
    {
        rb = GetComponent<Rigidbody>();
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");
    }    

    public void PlayerMove()
    {
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Áp dụng lực nhảy vào Rigidbody của player
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }  
    
}
