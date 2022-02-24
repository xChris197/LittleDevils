using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerCasting : MonoBehaviour
{
    public static float distanceFromTarget;
    public float toTarget;

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            distanceFromTarget = hit.distance;
            toTarget = distanceFromTarget;
        }
    }
}
