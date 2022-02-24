using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCR_LockedDoor : MonoBehaviour
{
    public int index = 0;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject[] locks;
    public AudioSource doorCreak;

    void Update()
    {
        if(index >= 5)
        {
            StartCoroutine(EndDoor());
        }
    }

    IEnumerator EndDoor()
    {
        locks[0].transform.parent = gameObject.transform;
        locks[1].transform.parent = gameObject.transform;
        locks[2].transform.parent = gameObject.transform;
        locks[3].transform.parent = gameObject.transform;
        locks[4].transform.parent = gameObject.transform;

        anim.SetBool("allUnlocked", true);
        doorCreak.Play();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Cutscene 3");
    }
}
