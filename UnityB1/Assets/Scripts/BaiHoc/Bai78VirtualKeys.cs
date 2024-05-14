using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai78VirtualKeys : MonoBehaviour
{
    public static int playerTurnAxisTouch;
    public static int playerMoveAxisTouch;
    void Start()
    {
        playerTurnAxisTouch = 0;
    }

    public void LeftPointerDown()
    {
        playerTurnAxisTouch = -1;
    }
    public void LeftPointerUp()
    {
        playerTurnAxisTouch = 0;
    }

    public void RightPointerDown()
    {
        playerTurnAxisTouch = 1;
    }
    public void RightPointerUp()
    {
        playerTurnAxisTouch = 0;
    }

    public void MovePointerDown()
    {
        playerMoveAxisTouch = 1;
    }
    public void MovePointerUp()
    {
        playerMoveAxisTouch = 0;
    }
}
