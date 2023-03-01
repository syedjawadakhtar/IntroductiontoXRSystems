using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TransformPlayer : MonoBehaviour
{
    public InputActionReference tf;
    public float speed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tf.action.Enable();
        tf.action.performed += (ctx) =>
        {
            // Debug.Log("Value: " + ctx.ReadValue<Vector2>());
            var v = tf.action.ReadValue<Vector2>();
            transform.position += new Vector3(v.x * speed * Time.deltaTime, 0, v.y*speed *Time.deltaTime);
        };
    }
}
