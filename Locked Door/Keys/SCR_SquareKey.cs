﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_SquareKey : MonoBehaviour
{
    private float distance;
    [SerializeField] GameObject interactionUI;
    [SerializeField] GameObject idleCrosshair;

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
            SCR_Inventory.carrySquareKey = true;
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