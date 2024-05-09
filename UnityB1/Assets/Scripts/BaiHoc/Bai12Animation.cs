using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai12Animation : MonoBehaviour
{
    Animator animator  ;
    void Start()
    {
        SetAnimation();
    } 
    public void SetAnimation()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isRun", true);
    }    
}
