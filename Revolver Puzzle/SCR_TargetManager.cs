using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SCR_TargetManager : MonoBehaviour
{
    [SerializeField] public int targetScore = 6;
    [SerializeField] private int targetGoal = 0;
    [SerializeField] private GameObject revolver;
    [SerializeField] private GameObject keyBox;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject revolverUI;

    [SerializeField] private GameObject targetUI;
    [SerializeField] private TextMeshProUGUI targetCount;
    public AudioSource hingeCreak;

    void Update()
    {
        targetCount.text = targetScore + " x ";

        if (targetScore <= targetGoal)
        {
            anim.SetBool("targetsDestroyed", true);
            hingeCreak.Play();
            Destroy(revolver);
            revolverUI.SetActive(false);
            targetUI.SetActive(false);
            keyBox.layer = 2;
            GetComponent<SCR_TargetManager>().enabled = false;
            GetComponent<SCR_RevolverManager>().enabled = false;
        }
    }
}
