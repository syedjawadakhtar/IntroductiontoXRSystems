using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followAlong : MonoBehaviour
{
    public Transform target;
    
    // Update is called once per frame
    void Update()
    {

        transform.LookAt(target.transform, Vector3.up);
        transform.Rotate(transform.rotation.x, transform.rotation.y - 180f, transform.rotation.z);
                
    }
}
