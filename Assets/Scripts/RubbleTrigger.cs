using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource playSound;

    void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }
}
