using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai77Character : MonoBehaviour
{
    CharacterController characterController;
    public float speedMove = 10f;
    public float speedJump = 10f;
    public float gravity = 20f;
    Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        if(characterController != null /*&& characterController.isGrounded*/)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f,/* Bai78VirtualKeys.playerMoveAxisTouch*/Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speedMove;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = speedJump;
            }
        }

        moveDirection.y *= gravity * Time.deltaTime;   
        characterController.Move(moveDirection * Time.deltaTime);

        //transform.Rotate(0, Bai78VirtualKeys.playerTurnAxisTouch, 0);

    }    
}
