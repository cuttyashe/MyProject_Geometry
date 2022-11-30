using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public float jumpSpeed = 5;
    public bool isGrounded = false;
    public int jumpCount = 2;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpCount = 0;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
            jumpCount = 2;
        }
    }

    private void Update()
    {
        if (isGrounded)
        {
            if (jumpCount>0)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    rb.AddForce(new Vector3(0, 1, 0) * jumpSpeed, ForceMode.Impulse);
                    jumpCount--;
                }
            }
        }
    }
}
