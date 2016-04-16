using UnityEngine;
using System.Collections;

public class RightStickInput : MonoBehaviour
{
    Rigidbody rb;
    float speed = 5.0f;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();   
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("HorizontalRight"), 0.0f, Input.GetAxis("VerticalRight"));
        movement *= speed;

        //Debug.Log(movement);
        rb.velocity = new Vector3(movement.x, movement.y, movement.z);

        movement = Vector3.zero;

    }
}
