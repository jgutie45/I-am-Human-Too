using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance = null;

    public int currentTeleportNumber;

    void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(int passedTeleportNumber)
    {
        currentTeleportNumber = passedTeleportNumber;
    }
}
