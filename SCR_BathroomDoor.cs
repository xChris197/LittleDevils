using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_BathroomDoor : MonoBehaviour
{
    private float distance;

    [SerializeField] private GameObject idleCrosshair;
    [SerializeField] private GameObject interactionUI;

    [SerializeField] private Animator anim;
    public AudioSource doorCreak;

    void Update()
    {
        distance = SCR_PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 2)
        {
            idleCrosshair.SetActive(false);
            interactionUI.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && distance <= 2 && SCR_Inventory.hasBathroomkey == true)
        {
            UnlockDoor();
        }
    }

    void OnMouseExit()
    {
        idleCrosshair.SetActive(true);
        interactionUI.SetActive(false);
    }

    void UnlockDoor()
    {
        anim.SetBool("bHasBathroomKey", true);
        doorCreak.Play();
        SCR_Inventory.hasBathroomkey = false;
        GetComponent<SCR_BathroomDoor>().enabled = false;
    }
}
