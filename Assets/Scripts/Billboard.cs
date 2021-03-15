using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // public Transform cam;
    Transform camTrans;

    void Start(){
        camTrans = Camera.main.GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // energy bar canvas always face to main camera
        // this.transform.LookAt(transform.position - camTrans.position);
        this.transform.LookAt(camTrans.position);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y+180, transform.rotation.eulerAngles.z);
    }
}
