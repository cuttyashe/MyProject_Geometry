using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float Speed = 10.0f;     

    float h, v;                     

    void Start()
    {

    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");      
        //v = Input.GetAxis("Vertical");          

        transform.position += new Vector3(h, 0, v) * Speed * Time.deltaTime;
    }
}