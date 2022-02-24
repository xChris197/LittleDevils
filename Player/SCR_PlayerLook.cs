using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerLook : MonoBehaviour
{
    public float mouseSpeed = 200f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        //Locks cursor so the player can't see it on screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //Gets x & y rotation and stores it
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        xRotation -= mouseY;

        //Stops the player from rotating 360 degrees
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
