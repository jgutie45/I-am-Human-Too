using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int maxScore = 5;

    int score; 

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "COLLECTED: " + score + " out of 5 notes"; 
        
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score++;
        if(score != maxScore){
            scoreText.text = "COLLECTED: " + score + " out of 5 notes";
        }
        else
        {
            scoreText.text = "All Notes Collected!";
        }            
    }

    public bool isCollected(){
        if(score == 5)
            return true;
        else
            return false;
    }
}
