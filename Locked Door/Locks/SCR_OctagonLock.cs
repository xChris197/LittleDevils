using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_OctagonLock : MonoBehaviour
{
    private float distance;
    [SerializeField] private GameObject idleCrosshair;
    [SerializeField] private GameObject interactionUI;
    [SerializeField] private Animator anim;

    [SerializeField] private GameObject door;
    [SerializeField] private SCR_LockedDoor lockedDoor;


    void Start()
    {
        lockedDoor = door.GetComponent<SCR_LockedDoor>();
    }

    void Update()
    {
        distance = SCR_PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 3f)
        {
            idleCrosshair.SetActive(false);
            interactionUI.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3f && SCR_Inventory.carryOctagonKey)
        {
            UnlockCircle();
        }
    }

    void OnMouseExit()
    {
        idleCrosshair.SetActive(true);
        interactionUI.SetActive(false);
    }

    void UnlockCircle()
    {
        anim.SetBool("octagonUnlocked", true);
        lockedDoor.index++;
        GetComponent<SphereCollider>().enabled = false;
    }
}
