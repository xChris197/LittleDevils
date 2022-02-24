using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_BathroomKey : MonoBehaviour
{
    private float distance;
    [SerializeField] private GameObject idleCrosshair;
    [SerializeField] private GameObject interactionUI;

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
            Pickup();
        }
    }

    void OnMouseExit()
    {
        idleCrosshair.SetActive(true);
        interactionUI.SetActive(false);
    }

    void Pickup()
    {
        SCR_Inventory.hasBathroomkey = true;
        idleCrosshair.SetActive(true);
        interactionUI.SetActive(false);
        Destroy(gameObject);
    }
}
