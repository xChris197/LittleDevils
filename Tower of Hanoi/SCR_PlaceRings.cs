using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlaceRings : MonoBehaviour
{
    private float distance;
    [SerializeField] private GameObject[] rings;
    [SerializeField] private Animator anim;
    [SerializeField] private int index = 0;
    [SerializeField] private GameObject box;

    public GameObject interactionUI;
    public GameObject idleCrosshair;
    public GameObject hingeCreak;

    private void Update()
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

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3 && SCR_Inventory.carryRed == true)
        {
            rings[0].SetActive(true);
            index++;
            SCR_Inventory.carryRed = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3 && SCR_Inventory.carryOrange == true)
        {
            rings[1].SetActive(true);
            index++;
            SCR_Inventory.carryOrange = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3 && SCR_Inventory.carryYellow == true)
        {
            rings[2].SetActive(true);
            index++;
            SCR_Inventory.carryYellow = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3 && SCR_Inventory.carryGreen == true)
        {
            rings[3].SetActive(true);
            index++;
            SCR_Inventory.carryGreen = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3 && SCR_Inventory.carryBlue == true)
        {
            rings[4].SetActive(true);
            index++;
            SCR_Inventory.carryBlue = false;
        }

        if (index == 5)
        {
            anim.SetBool("placedAll", true);
            box.layer = 2;
            hingeCreak.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        interactionUI.SetActive(false);
        idleCrosshair.SetActive(true);
    }
}
