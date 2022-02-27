using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//since we are working with UI element

public class Score : MonoBehaviour
{
    public Text scoreText;// creating a variable scoreText to get the text field.
    int myScore=0;   
   
    // Update is called once per frame
    void Update()
    {
        scoreText.text = myScore.ToString();  //converting int to String and then storing it to the score text container.
        
    }
    public void AddScore(int score)  //method to increment myScore variable 
    {
        myScore = myScore + score;  

    }
}
