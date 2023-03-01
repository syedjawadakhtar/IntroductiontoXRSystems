using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerTransform : MonoBehaviour
{
    public InputActionReference tf;
    private Vector3 InitialPosition = new Vector3(0.0f, 4.0f, -6.5f);
    private Vector3 TransformPosition = new Vector3(-23.5f, 17.5f, -10f);

    // tf = GetComponent<transform>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tf.action.Enable();
        if (transform.position == InitialPosition){
            tf.action.performed += (ctx) =>
            {
                transform.position = TransformPosition;
            };
        }
        if (transform.position == TransformPosition){
            tf.action.performed += (ctx) =>
            {
                transform.position = InitialPosition;
            };
        }
    }
}
