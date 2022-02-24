using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCR_TutorialLock : MonoBehaviour
{
    private float distance;
    [SerializeField] private GameObject roomLock;
    [SerializeField] private GameObject roomDoor;

    [SerializeField] private GameObject idleCrosshair;
    [SerializeField] private GameObject interactionUI;

    public Animator anim;
    public Animator doorAnim;
    public AudioSource doorCreak;

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

        if (Input.GetKeyDown(KeyCode.E) && distance <= 3 && SCR_Inventory.hasTutorialKey == true)
        {
            StartCoroutine(UnlockDoor());
        }
    }

    void OnMouseExit()
    {
        idleCrosshair.SetActive(true);
        interactionUI.SetActive(false);
    }

    IEnumerator UnlockDoor()
    {
        anim.SetBool("isUnlocked", true);
        yield return new WaitForSeconds(1.2f);
        roomLock.transform.parent = roomDoor.transform;
        doorAnim.SetBool("hasUnlocked", true);
        doorCreak.Play();
        roomDoor.transform.parent = roomLock.transform;
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Cutscene 2");
    }
}
