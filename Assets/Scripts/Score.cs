using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public int score; 

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        score++;
        scoreText.GetComponent<Text>().text = "COLLECTED: " + score + " out of 5 notes";
        Destroy(gameObject);
                     
    }
}
