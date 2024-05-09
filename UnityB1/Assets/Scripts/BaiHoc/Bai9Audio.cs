using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai9Audio : MonoBehaviour
{
    public AudioClip music;
    private AudioSource audioSource;
    void Start()
    {
        AudioSourcePlay();
    }

    private void AudioSourcePlay()
    {
        audioSource= GameObject.Find("Cube").GetComponent<AudioSource>();
        audioSource.clip = music;
        audioSource.Play();
    }

}
