using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Transform Lever;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        // posCube = tranform.position.y;
        offset = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // new Vector3 posCube += Lever.rotation.z;
        float z = Lever.transform.rotation.z;
        
        float transformY = -((z/12f) * 45f);


        this.transform.position = new Vector3(offset.x, transformY+offset.y, offset.z);
    }
}
