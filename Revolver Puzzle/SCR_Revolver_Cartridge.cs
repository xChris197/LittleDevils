using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Revolver_Cartridge : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private GameObject interactionUI;
    [SerializeField] private GameObject idleCrosshair;
    [SerializeField] private GameObject gameManager;
    [SerializeField] private GameObject player;

    private SCR_RevolverManager gunManager;
    private SCR_Inventory weaponBool;

    void Start()
    {
        gunManager = gameManager.GetComponent<SCR_RevolverManager>();
        weaponBool = player.GetComponent<SCR_Inventory>();
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
            gunManager.AddPart(1);
            GunPieceHint.numberOfGunParts += 1;
            weaponBool.hasGunCartridge = true;
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