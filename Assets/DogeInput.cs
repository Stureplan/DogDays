using UnityEngine;
using System.Collections;

public class DogeInput : MonoBehaviour
{
    Vector3 def;
    Rigidbody rb;
    float speed = 10.0f;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        def = transform.position;
	}
	
	void Update ()
    {
        float hSpeed = Input.GetAxis("HorizontalRight2");
        float vSpeed = Input.GetAxis("VerticalRight2");

        if (hSpeed < 0.2f && hSpeed > -0.2f)
        {
            if (vSpeed < 0.2f && vSpeed > -0.2f)
            {
                LerpTowards(def);

            }

        }

    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("HorizontalRight2"), Input.GetAxis("VerticalRight2"), 0.0f);
        movement *= speed;
        rb.velocity = new Vector3(movement.x, movement.y, movement.z);

        movement = Vector3.zero;
    }

    void LerpTowards(Vector3 pos)
    {
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * 2.0f);
    }
}
