﻿using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class PyttInPanUI : MonoBehaviour {

	// Use this for initialization

    Pan pan;
    GameObject gamePan;

    public Text text;

    string origString;
	void Start ()
    {
        gamePan = GameObject.Find("pan_Left");

        pan = gamePan.GetComponent<Pan>();

        origString = "Pytt in Pan : ";
	}
	
	// Update is called once per frame
	void Update () 
    {
        text.text = origString + pan.GetNrOfFoods().ToString();

        if(pan.GetNrOfFoods() > 50)
        {

        }
	}
}