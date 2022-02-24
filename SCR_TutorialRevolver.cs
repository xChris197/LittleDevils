using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_TutorialRevolver : MonoBehaviour
{
    private float distance;

    [SerializeField] private GameObject revolver;
    [SerializeField] private GameObject revolverUI;

    [SerializeField] private GameObject targetUI;

    [SerializeField] private GameObject idleCrosshair;
    [SerializeField] private GameObject interactionUI;

    void Update()
    {
        distance = SCR_PlayerCasting.distanceFromTarget;

    }

    void EnableRevolver()
    {
        revolver.SetActive(true);
        revolverUI.SetActive(true);
        targetUI.SetActive(true);
        Destroy(transform.parent.gameObject);
    }

    void OnMouseOver()
    {
        if (distance <= 2)
        {
            idleCrosshair.SetActive(false);
            interactionUI.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                EnableRevolver();
            }

        }
    }
    void OnMouseExit()
    {
        idleCrosshair.SetActive(true);
        interactionUI.SetActive(false);
    }
}
