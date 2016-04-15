﻿using UnityEngine;
using System.Collections;

public class RightStickInput : MonoBehaviour
{
    Rigidbody rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();   
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        
        if (movement.x < 0.1f)
        {
            //movement.x = 0.0f;
        }

        if (movement.z < 0.1f)
        {
           // movement.z = 0.0f;
        }

        Debug.Log(movement);
        rb.velocity = new Vector3(movement.x, movement.y, movement.z);
	}
}
