using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
   public GameObject CubeMove;

    void OnTriggerEnter(Collider other)
        {
            if (CubeMove.activeSelf == false){
                CubeMove.SetActive(true);
                GetComponent<Rigidbody>().position += new Vector3(0f,0.25f,0f);

            }
            if (CubeMove.activeSelf == true){
                CubeMove.SetActive(false);
                GetComponent<Rigidbody>().position += new Vector3(0f,-0.25f,0f);
            }
            // Debug.Log("Object has entered the trigger");
        }
        void OnTriggerStay (Collider other)
        {
            Debug.Log ("Object is within trigeer");
        }
        void OnTriggerExit (Collider other)
        {
            Debug.Log ("Object exited the trigeer");
        }

}
