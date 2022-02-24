using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_BarF : MonoBehaviour
{
    private float distance;
    public GameObject idleCrosshair;
    public GameObject interactionUI;
    public AudioSource barFSound;

    public GameObject xylophone;
    public SCR_NewXylophone xyloScript;

    void Start()
    {
        xyloScript = xylophone.GetComponent<SCR_NewXylophone>();
    }

    void Update()
    {
        distance = SCR_PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 3)
        {
            idleCrosshair.SetActive(false);
            interactionUI.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && SCR_Inventory.carryMallet && distance <= 3)
        {
            //xyloScript.index++;
            xyloScript.AddPlayerInput(4);
            barFSound.Play();
        }
    }

    void OnMouseExit()
    {
        idleCrosshair.SetActive(true);
        interactionUI.SetActive(false);
    }
}
