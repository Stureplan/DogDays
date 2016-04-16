using UnityEngine;
using System.Collections;

public class Pan : MonoBehaviour {

	// Use this for initialization

    private int nrOfFoodCol;

	void Start () {
        nrOfFoodCol = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Food")
        {
            nrOfFoodCol++;

        }
    }
}
