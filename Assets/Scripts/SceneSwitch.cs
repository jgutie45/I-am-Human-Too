using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public Score scoreManager;
    void OnTriggerEnter(Collider other)
    {
        if(scoreManager.isCollected()){
            Debug.Log("collected all 5 notes, transition to Park");
            SceneManager.LoadScene(sceneName:"ParkScene");
        }
        else{
            Debug.Log("did not collect 5 notes!");
        }
    }
}
