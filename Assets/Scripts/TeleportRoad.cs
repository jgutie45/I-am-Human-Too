using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRoad : MonoBehaviour
{
    public int teleportNumber;

    void OnTriggerStay()
    {
        SceneManager.instance.LoadScene(teleportNumber);
    }
}
