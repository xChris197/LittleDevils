using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintAudioPlaying : MonoBehaviour
{
    AudioSource audioSource;

    public static bool hintAudioPlaying;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hintAudioPlaying = false;
    }

    
    void Update()
    {
        if (audioSource.isPlaying == true)
        {
            hintAudioPlaying = true;
        }
        if (!audioSource.isPlaying)
        {
            hintAudioPlaying = false;
        }
    }
}
