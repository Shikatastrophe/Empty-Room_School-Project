using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to this game object
        // Start the PlayRandomAudio coroutine
        StartCoroutine(PlayRandomAudio());
    }

    // A coroutine that plays random audio clips with a delay
    IEnumerator PlayRandomAudio()
    {
        // Loop indefinitely
        while (true)
        {
            // Get a random index between 0 and the length of the audio clips array
            int randomIndex = Random.Range(0, audioClips.Length);
            // Get the audio clip at the random index
            AudioClip randomClip = audioClips[randomIndex];
            // Play the audio clip
            src.PlayOneShot(randomClip);
            // Wait for 25 seconds before playing the next clip
            yield return new WaitForSeconds(25f);
        }
    }
}
