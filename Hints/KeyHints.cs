using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHints : MonoBehaviour
{

    public static int numberOfkeys;

    public GameObject Hint1;
    public GameObject Hint2;
    public GameObject Hint3;
    public GameObject Hint4;
    public GameObject Hint5;

    void Start()
    {
        numberOfkeys = 0;
    }

   
    void Update()
    {
        if (numberOfkeys >= 1 && HintAudioPlaying.hintAudioPlaying == false)
        {
            Hint1.SetActive(true);
        }
        if (numberOfkeys >= 2 && HintAudioPlaying.hintAudioPlaying == false)
        {
            Hint2.SetActive(true);
        }
        if (numberOfkeys >= 3 && HintAudioPlaying.hintAudioPlaying == false)
        {
            Hint3.SetActive(true);
        }
        if (numberOfkeys >= 4 && HintAudioPlaying.hintAudioPlaying == false)
        {
            Hint4.SetActive(true);
        }
        if (numberOfkeys >= 5 && HintAudioPlaying.hintAudioPlaying == false)
        {
            Hint5.SetActive(true);
        }
    }
}
