using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        else if(collision.collider.gameObject.CompareTag("Clear"))
        {
            Destroy(gameObject);
        }
    }
}
