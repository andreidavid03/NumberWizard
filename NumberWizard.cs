using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{     
        int max;
        int min;
        int guess;


    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard,yo");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is " + max);
        Debug.Log("Lowest number is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up = higher,Push down = lower,Push enter = Correct");
        max= max + 1;
    }

    void Update()
    {
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
  
         else if(Input.GetKeyDown(KeyCode.Return))
         {
            Debug.Log("I am a genius.");
            StartGame();
         }
         
            
}
    void NextGuess()
     {
        guess = (min + max) / 2;
        Debug.Log("Is it higher or lower than " + guess);
     }

}


