using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float speed = 1;
    Rigidbody rbody;
    public string targetObject;

    void Start()
    {
        Time.timeScale = 2;
        rbody = GetComponent<Rigidbody>();

        //rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        rbody.velocity = new Vector2(speed, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
        }

        speed = -speed;
        this.GetComponent<SpriteRenderer>().flipX = (speed < 0);
    }
}
