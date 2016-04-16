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
        LerpTowards(def);

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
