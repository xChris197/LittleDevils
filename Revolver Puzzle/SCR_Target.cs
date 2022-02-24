using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Target : MonoBehaviour
{
    [SerializeField] private GameObject targetManager;
    [SerializeField] private SCR_TargetManager targetScript;

    void Start()
    {
        targetScript = targetManager.GetComponent<SCR_TargetManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            AddPoint();
        }
    }

    void AddPoint()
    {
        targetScript.targetScore--;
        Destroy(gameObject);
    }
}
