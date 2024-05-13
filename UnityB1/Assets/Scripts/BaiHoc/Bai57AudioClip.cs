using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai57AudioClip : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("casual_02_loop");
        audioSource.PlayDelayed(5f);
    }

 
}
