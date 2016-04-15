using UnityEngine;
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
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Debug.Log(movement);
        rb.AddForce(movement.x, movement.y, 0.0f);
	}
}
