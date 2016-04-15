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
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f,0.0f);
        Debug.Log(movement);
        // rb.AddForce(movement, ForceMode.Impulse);
     //   rb.velocity.Set(movement.x, movement.y, movement.z);
        rb.velocity = new Vector3(movement.x, movement.y,movement.z);
	}
}
