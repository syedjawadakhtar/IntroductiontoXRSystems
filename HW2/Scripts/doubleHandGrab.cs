using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class doubleHandGrab : MonoBehaviour
{
    public InputActionReference grb;
    public InputActionReference doublebtn;
    public Transform Cube;
    public Vector3 lastPos;
    public Quaternion lastRot;
    // public GameObject attachPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grb.action.Enable();
        if(Cube){
            if(grb.action.IsPressed()){
                Vector3 deltaPos = transform.position - lastPos;
                // Cube.position += deltaPos;
                Quaternion deltaRot = transform.rotation*Quaternion.Inverse(lastRot);
                Cube.rotation = deltaRot*Cube.rotation;

                // Do same for pivot position
                Vector3 initialVector = Cube.position - transform.position;
                Vector3 turnedVector = deltaRot*initialVector;
                Vector3 turnPosition = turnedVector - initialVector;
                Cube.position += deltaPos + turnPosition;
                
                if(doublebtn.action.IsPressed()){
                    deltaRot *= deltaRot;
                }
            }
        }
        lastPos = transform.position;
        lastRot = transform.rotation;
    }
    

    void OnTriggerEnter(Collider other){
        Cube = other.transform;
    }  
}
