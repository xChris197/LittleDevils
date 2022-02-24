using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_TowerRingGreen : MonoBehaviour
{
    public float distance;
    public GameObject interactionUI;
    public GameObject idleCrosshair;

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

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3)
        {
            SCR_Inventory.carryGreen = true;
            interactionUI.SetActive(false);
            idleCrosshair.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    private void OnMouseExit()
    {
        interactionUI.SetActive(false);
        idleCrosshair.SetActive(true);
    }
}
