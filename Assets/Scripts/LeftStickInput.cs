using UnityEngine;
using System.Collections;

public class LeftStickInput : MonoBehaviour {

    private Vector3 moveDirection = Vector3.zero;
    float moveSpeed = 3.0f;

    Rigidbody rb;
    Rigidbody rbHand;
    GameObject hand;

	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody>();
        hand = GameObject.Find("handG_Left");
        rbHand = hand.GetComponent<Rigidbody>();
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button4))
        {
            rbHand.AddForce(Vector3.up * 500.0f, ForceMode.Force);
        }
    }
	
	// Update is called once per frame
    void FixedUpdate()
    {
        moveDirection =new Vector3(Input.GetAxis("HorizontalLeft"),0.0f, Input.GetAxis("VerticalLeft"));
        
        rb.velocity = moveDirection * moveSpeed;

        moveDirection = Vector3.zero;
    }
}
