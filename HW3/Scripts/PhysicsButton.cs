using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = .1f; // The amount pressed to activate the button
    [SerializeField] private float deadZone = .025f; // prevent any bouncyness of the button.. press and releaase the button the whole time

    private bool _isPressed; // keep track if the button is already pressed and not send onPressed event again and again; state management 
    private Vector3 _startPos;  // compare the start position to the current position
    private ConfigurableJoint _joint;   // joint and get the linear limit from there

    public UnityEvent onPressed, onReleased;
    
    void Start()
    {
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
    }

    void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
            Pressed();
        if(_isPressed && GetValue() - threshold <= 0)
            Released();
    }

    private float GetValue(){
        var value = Vector3.Distance(_startPos, transform.localPosition)/_joint.linearLimit.limit;

        if(Math.Abs(value) < deadZone){
            value = 0;
        }
        return Mathf.Clamp(value, -1f, 1f);
    }
    private void Pressed(){
        _isPressed = true;
        onPressed.Invoke();
        Debug.Log("Pressed");
    }

    private void Released(){
        _isPressed = false;
        onReleased.Invoke();
        Debug.Log("Released");
    }

}
