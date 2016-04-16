using UnityEngine;
using System.Collections;

public class RightStickInput : MonoBehaviour
{
    GameObject hand;
    Rigidbody rb;
    float speed = 5.0f;
    float shakeSpeed = 10.0f;
    float degrees = 30.0f;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        hand = GameObject.Find("BoxG_Right");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Joystick1Button5))
        {
            LerpTowards(1);
        }
        else
        {
            LerpTowards(0);
        }
	}

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("HorizontalRight"), 0.0f, Input.GetAxis("VerticalRight"));
        movement *= speed;

<<<<<<< HEAD
        //Debug.Log(movement);
=======
>>>>>>> origin/master
        rb.velocity = new Vector3(movement.x, movement.y, movement.z);

        movement = Vector3.zero;

    }


    void LerpTowards(int mode)
    {
        if (mode == 1)
        {
            hand.transform.localRotation = Quaternion.Lerp(hand.transform.localRotation, Quaternion.Euler(degrees, -180, -180), Time.deltaTime * shakeSpeed);
        }
        else
        {
            hand.transform.localRotation = Quaternion.Lerp(hand.transform.localRotation, Quaternion.Euler(60, -180, -180), Time.deltaTime * shakeSpeed);
        }

        Debug.Log(hand.transform.localRotation);
    }
}
