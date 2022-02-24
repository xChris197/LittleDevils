using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] private float movementSpeed = 4f;
    [SerializeField] private float gravity = -4.38f;
    [SerializeField] private float jumpHeight = 2f;

    [SerializeField] private Transform groundChecker;
    [SerializeField] private float groundRadius = 0.5f;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private Camera mainCam;

    private Animator anim;
    private bool bIsGrounded;

    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = mainCam.GetComponent<Animator>();
    }

    void Update()
    {
        bIsGrounded = Physics.CheckSphere(groundChecker.position, groundRadius, groundMask);
        if (bIsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        controller.Move(move * movementSpeed * Time.deltaTime);
        if (move.x > 0 || move.z > 0)
        {
            anim.SetBool("bIsMoving", true);
        }
        else
        {
            anim.SetBool("bIsMoving", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && bIsGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}