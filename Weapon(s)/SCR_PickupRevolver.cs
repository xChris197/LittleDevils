using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PickupRevolver : MonoBehaviour
{
    private float distance;
    [SerializeField] private GameObject revolver;

    [SerializeField] GameObject idleCrosshair;
    [SerializeField] GameObject interactionUI;
    [SerializeField] GameObject revolverUI;

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
        revolver.SetActive(true);
        revolverUI.SetActive(true);
        Destroy(gameObject);
    }
}