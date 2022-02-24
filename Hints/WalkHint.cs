using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkHint : MonoBehaviour
{
    public GameObject Hint;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && HintAudioPlaying.hintAudioPlaying == false)
        {
            Hint.SetActive(true);
        }
    }
}
