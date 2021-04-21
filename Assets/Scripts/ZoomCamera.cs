using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// reference: https://www.youtube.com/watch?v=4yK4PoZQ4qI
public class ZoomCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // zoom in
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y-.4f, transform.position.z+.3f);
            // transform.Rotate(-2, 0, 0);
        }
        // zoom out
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y+.4f, transform.position.z-.3f);
            // transform.Rotate(-2, 0, 0);
        }
    }
}
