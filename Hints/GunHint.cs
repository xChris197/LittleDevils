using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHint : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject Hint;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //HintAudioPlaying.hintAudioPlaying = true;
    }

    
    void Update()
    {

        //if (!audioSource.isPlaying)
        //{
           // HintAudioPlaying.hintAudioPlaying = false;
        //}
        if (HintAudioPlaying.hintAudioPlaying == false)
        {
            Hint.SetActive(true);
        }
    }
}
