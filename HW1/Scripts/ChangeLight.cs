using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeLight : MonoBehaviour
{
    public InputActionReference changeLight;
    Light chnglight;
    // Start is called before the first frame update
    void Start()
    {
        changeLight.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        chnglight = GetComponent<Light>();
        
        if (chnglight.color == Color.white){
            changeLight.action.performed += (ctx) =>
            {
                chnglight.color = Color.blue;
            };
        }
        if (chnglight.color == Color.blue){
            changeLight.action.performed += (ctx) =>
            {
                chnglight.color = Color.white;
            };
        }
    }
}
