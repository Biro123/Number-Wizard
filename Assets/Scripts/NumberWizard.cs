using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();                
    }

    void StartGame () {
        max = 1000;
        min = 1;
        guess = 500;

        print("==================================================");
        print("Welcome to Number Wizard");
        print("Think of a Number - but don't tell me!");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number you picked higher or lower than " + guess);
        print("UP for higher, DOWN for lower, RETURN for equal");

        max = max + 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I Won!");
            StartGame();
        }
    }

    void NextGuess() {
        guess = (min + max) / 2;
        print("Is the number you picked higher or lower than " + guess);
        print("UP for higher, DOWN for lower, RETURN for equal");

    }

}
