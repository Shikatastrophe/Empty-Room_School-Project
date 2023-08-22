using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voicestart : MonoBehaviour
{
    public AudioSource src;
    public AudioClip intro;

    public void PlayIntro()
    {
        src.clip = intro;
        src.Play();
    }
}
