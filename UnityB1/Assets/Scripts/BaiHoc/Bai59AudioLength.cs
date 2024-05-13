using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai59AudioLength : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("CheckAudio", audioSource.clip.length);

    }

    public void CheckAudio()
    {
        Debug.Log("Audio stop");
    }    

}
