﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Welcome to Number Wizard");
        print("Think of a Number - but don't tell me!");

        int max = 1000;
        int min = 1;

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number you picked higher or lower than 500?");
        print("UP for higher, DOWN for lower, RETURN for equal");

        
    }
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.UpArrow) )
        {
            print("Up Arrow pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) )
        {
            print("Down Arrow pressed");
        }

    }
}