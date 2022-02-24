using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPieceHint : MonoBehaviour
{

    public static int numberOfGunParts;

    public GameObject Hint;

    void Start()
    {
        numberOfGunParts = 0;
    }

    
    void Update()
    {
        if (numberOfGunParts >= 1 && HintAudioPlaying.hintAudioPlaying == false)
        {
            Hint.SetActive(true);
        }
    }
}
