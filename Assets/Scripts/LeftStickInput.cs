using UnityEngine;
using System.Collections;

public class LeftStickInput : MonoBehaviour {

    private Vector3 moveDirection = Vector3.zero;
    float moveSpeed = 3.0f;

    Rigidbody rb;
	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        moveDirection =new Vector3(Input.GetAxis("HorizontalLeft"),0.0f, Input.GetAxis("VerticalLeft"));
        
        rb.velocity = moveDirection * moveSpeed;

        moveDirection = Vector3.zero;
    }
}
