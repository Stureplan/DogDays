using UnityEngine;
using System.Collections;

public class KillFood : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Food")
        {
            Destroy(col.gameObject, 1.0f);
        }
    }
}
