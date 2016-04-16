using UnityEngine;
using System.Collections;

public class DogeInput : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10.0f;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {

	}

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("HorizontalRight2"), Input.GetAxis("VerticalRight2"), 0.0f);
        movement *= speed;
        rb.velocity = new Vector3(movement.x, movement.y, movement.z);

        movement = Vector3.zero;
    }
}
