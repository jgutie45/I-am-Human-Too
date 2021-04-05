using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    void Awwake(){
        DontDestroyOnLoad(transform.gameObject);
    }
}
