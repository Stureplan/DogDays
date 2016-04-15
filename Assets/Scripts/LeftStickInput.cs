using UnityEngine;
using System.Collections;

public class LeftStickInput : MonoBehaviour {

    private Vector3 moveDirection = Vector3.zero;
    public float moveSpeed;

    Rigidbody rb;
	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        moveDirection =new Vector3( Input.GetAxis("Horizontal") * moveSpeed,0, Input.GetAxis("Vertical") * moveSpeed);

        //moveDirection = transform.TransformDirection(moveDirection);
        rb.AddForce(moveDirection,ForceMode.Force);

        moveDirection = Vector3.zero;
       // transform.Translate(transform.position + moveDirection);
    }
}
