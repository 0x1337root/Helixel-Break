using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody rb;

    private float jumpSpeed = 7f;

    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(new Vector3(0, 1, 0) * jumpSpeed, ForceMode.Impulse);
            }

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if(touch.phase == TouchPhase.Began)
                {
                    rb.AddForce(new Vector3(0, 1, 0) * jumpSpeed, ForceMode.Impulse);
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
