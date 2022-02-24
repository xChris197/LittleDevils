using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_NewXylophone : MonoBehaviour
{
    // SerializeField allows you to keep the variable private while being able to edit it in the inspector
    [SerializeField] private int[] correctSequence = { 1, 1, 5, 5, 6, 6, 5 };
    [SerializeField] public Animator anim;
    [SerializeField] public AudioSource incorrectSound;
    [SerializeField] public AudioSource successSound;
    [SerializeField] private int _playerInputIndex = 0;

    [SerializeField] private GameObject xyloBox;
    public AudioSource hingeCreak;

    public void AddPlayerInput(int value)
    {
        // Reset if incorrect value provided
        if (value != correctSequence[_playerInputIndex])
        {
            _playerInputIndex = 0;
            incorrectSound.Play();
            return;
        }
        else
        {
            _playerInputIndex++;
        }

        // Last input reached, meaning all the values are correct
        if (_playerInputIndex == correctSequence.Length)
        {
            _playerInputIndex = 0;
            StartCoroutine(SuccessSequence());
            GetComponent<SCR_NewXylophone>().enabled = false;
        }
    }
    IEnumerator SuccessSequence()
    {
        anim.SetBool("playedTune", true);
        xyloBox.layer = 2;
        hingeCreak.Play();
        SCR_Inventory.carryMallet = false;
        //successSound.Play();
        yield return new WaitForSeconds(1f);
        successSound.Stop();
    }
}
