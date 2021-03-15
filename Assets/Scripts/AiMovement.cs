using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 1f;
    public float rushSpeed = 2f;

    private int interval = 5;   // 5 second
    private float nextTime = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        
        // for every interval second, AI rotate 90 degree
        if (Time.time >= nextTime)
        {
            transform.Rotate(0f, -90f, 0f);
            nextTime += interval;
        }
    }
}
