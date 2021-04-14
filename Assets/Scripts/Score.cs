using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreText1;
    public Text scoreText;
    public int maxScore = 5;

    int score; 

    // Start is called before the first frame update
    void Start()
    {
        
        score=0;
        scoreText.text = "COLLECTED: " + score + " out of 5 notes"; 
        
    }

    // Update is called once per frame
    public void AddPoint(Collider other)
    {
        score++;
        if(score != maxScore){
                scoreText.text = "COLLECTED: " + score + " out of 5 notes";
                Destroy(gameObject);
            }
            else
            {
                scoreText.text = "All Notes Collected!";
            }            
        }
}
