﻿using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class PyttInPanUI : MonoBehaviour {

	// Use this for initialization

    Pan pan;
    GameObject gamePan;

    bool gameOver;

    public Text counterOfPytt;
    public Text timeCount;

    public Text winner;

    float timeDown;

    string origString;

    public GameObject winShow;

    Choice choice;

	void Start ()
    {
        gameOver = false;
        winShow.SetActive(false);
        gamePan = GameObject.Find("pan_Left");

        pan = gamePan.GetComponent<Pan>();

        origString = "Pytt in Pan : ";

        choice = Choice.Play;

        timeDown = 10;

        winner.text = "Human Win";

        //winShow.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (!gameOver)
            timeDown -= Time.deltaTime;

        int intTime = (int)timeDown;
        timeCount.text = intTime.ToString();


        counterOfPytt.text = origString + pan.GetNrOfFoods().ToString();

        if (pan.GetNrOfFoods() > 10 && !gameOver)
        {
            winShow.SetActive(true);

            gameOver = true;
        }

        else if (timeDown <= 0 && !gameOver)
        {
            timeDown = 0;
            winShow.SetActive(true);
            winner.text = "DOG Win";
            //winShow.
            gameOver = true;
        }
	}
}
