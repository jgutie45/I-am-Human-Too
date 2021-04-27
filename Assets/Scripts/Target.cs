using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Score scoreManager;
    public AudioSource collectSound;
 
    //this method is called whenever a collision is detected
    private void OnTriggerEnter(Collider collision) {
        collectSound.Play();
        //on collision adding point to the score
        scoreManager.AddPoint();
 
        // printing if collision is detected on the console
        Debug.Log("Collision Detected");
        //after collision is detected destroy the gameobject
        Destroy(gameObject);
    }
}
