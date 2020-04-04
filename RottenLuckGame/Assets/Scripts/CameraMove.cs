using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public float smooth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       
        if (transform.position != target.position) {
            //our targets position
            
            Vector3 targetpos = new Vector3(target.position.x, target.position.y, transform.position.z);
            
            transform.position = Vector3.Lerp(transform.position, targetpos, smooth);
        }
    }
}
