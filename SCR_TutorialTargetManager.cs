using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SCR_TutorialTargetManager : MonoBehaviour
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
            Destroy(revolver);
            revolverUI.SetActive(false);
            targetUI.SetActive(false);
            keyBox.layer = 2;
            GetComponent<SCR_TutorialTargetManager>().enabled = false;
            hingeCreak.Play();
        }
    }
}
