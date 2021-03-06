using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_HexagonKey : MonoBehaviour
{
    private float distance;
    [SerializeField] private GameObject interactionUI;
    [SerializeField] private GameObject idleCrosshair;

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
            SCR_Inventory.carryHexagonKey = true;
            interactionUI.SetActive(false);
            idleCrosshair.SetActive(true);
            KeyHints.numberOfkeys++;
            Destroy(gameObject);
        }
    }
    void OnMouseExit()
    {
        interactionUI.SetActive(false);
        idleCrosshair.SetActive(true);
    }
}
