// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BoxPackage : MonoBehaviour
// {
//     public Material PackagedMat;
//     private Transform endpoint;

//     public void ChangeColorPosition(){
//         PackageMat.color = new Color (195, 87, 80);
//         endpoint.position = new Vector(0,0.75, 1.174);
//     }

//     void OnTriggerStay(Collider other){
//         if (other.gameObject.tag == "PackageArea"){
//             GetComponent<Renderer>.color = PackagedMat.color;
//             tranform.position = endpoint.position;
//         }

//     }
// }
