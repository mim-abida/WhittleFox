using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    private CharacterController controller;

    private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 10.0f;

    public int PlayerHealth = 100;
    public float PlayerSpeed;

    //colission stuff
    public bool stopright;

    private Rigidbody rig;

    private void FixedUpdate()
    {
        stopright = Physics.Raycast(transform.position, Vector3.right, .67f);
    }

    void Start()
    {
        /* rig = GetComponent<Rigidbody>();*/
        controller = GetComponent<CharacterController>();
    }
   

     private void Update()
    {
        /*
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * PlayerSpeed * Time.deltaTime;


        rig.MovePosition(transform.position + movement);
        */

        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        Vector3 moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * PlayerSpeed;
        moveVector.y = verticalVelocity;
        moveVector.z = Input.GetAxis("Vertical") * PlayerSpeed;
        controller.Move(moveVector * Time.deltaTime);
    }
}
