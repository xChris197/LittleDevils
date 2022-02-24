using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_AmmoBox : MonoBehaviour
{
    private float distance;

    [SerializeField] private GameObject revolver;
    [SerializeField] private SCR_Revolver gunScript;
    [SerializeField] private GameObject interactionUI;
    [SerializeField] private GameObject idleCrosshair;

    void Start()
    {
        gunScript = revolver.GetComponent<SCR_Revolver>();
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

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3)
        {
            interactionUI.SetActive(false);
            idleCrosshair.SetActive(true);
            gunScript.currentAmmo = gunScript.maxAmmo;
        }
    }
    void OnMouseExit()
    {
        interactionUI.SetActive(false);
        idleCrosshair.SetActive(true);
    }
}
