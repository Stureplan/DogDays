using UnityEngine;
using System.Collections;

public class RightStickInput : MonoBehaviour
{
    public GameObject food;
    GameObject hand;
    GameObject box;
    Rigidbody rb;
    Rigidbody rbBox;
    float speed = 3.0f;
    float shakeSpeed = 10.0f;
    float degrees = 30.0f;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        hand = GameObject.Find("BoxG_Right");
        box = GameObject.Find("box_Right");
        rbBox = hand.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Joystick1Button5))
        {
        }
        else
        {
           // LerpTowards(0);
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button5))
        {
            LerpTowards();

            //TODO: Create GetKeyDown and spawn 5 each time its pressed
            for (int i = 0; i < 5; i++)
            {
                Instantiate(food, box.transform.position, Quaternion.identity);

            }
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("HorizontalRight"), 0.0f, Input.GetAxis("VerticalRight"));
        movement *= speed;
        rb.velocity = new Vector3(movement.x, movement.y, movement.z);

        movement = Vector3.zero;

    }


    void LerpTowards()
    {
        // hand.transform.localRotation = Quaternion.Lerp(hand.transform.localRotation, Quaternion.Euler(degrees, 70, 70), Time.deltaTime * shakeSpeed);
        rbBox.AddForce(Vector3.up * 500.0f, ForceMode.Force);
    }
}
