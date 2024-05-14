using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai81AniDoor : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other != null && other.gameObject.tag == "Player")
        {
            animator.SetTrigger("Close");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other != null && other.gameObject.tag == "Player")
        {
            animator.enabled = true;
        }
     
    }

    public void SetEven()
    {

        animator.enabled = false;
    }    
}
