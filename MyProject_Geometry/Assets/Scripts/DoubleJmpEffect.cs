using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJmpEffect : MonoBehaviour
{
    public GameObject effect;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Double"))
        {
            Instantiate(effect, transform.position, transform.rotation);
        }
    }
}
