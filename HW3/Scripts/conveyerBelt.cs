using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyerBelt : MonoBehaviour
{
    public GameObject belt;
    public Transform endpoint;
    public float speed = 0;

    public void switchOn(){
        speed = 0.5f;
    }

    public void switchOff(){
        speed = 0f;
    }

    void OnTriggerStay(Collider other){   
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
        // StartCoroutine(DelayBelt());
    }

    // IEnumerator DelayBelt(){
    //     yield return new WaitForSeconds(100);
    // }
}
