using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class packBox : MonoBehaviour
{
    public GameObject Box;
    public Material PackagedMat;
    public Transform endpoint;
    public float delay;
    
    void OnTriggerEnter(Collider other){
        
        if (other.gameObject.tag == "Packager"){
            Box.GetComponent<Renderer>().material = PackagedMat;
            StartCoroutine(DelayPack());
        }
    }

    IEnumerator DelayPack(){
        yield return new WaitForSeconds(delay);
        // Debug.Log("Delaying 3 seconds");
        Box.transform.position = endpoint.position;
    }
}
