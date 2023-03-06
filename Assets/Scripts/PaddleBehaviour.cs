using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleBehaviour : MonoBehaviour
{
    [SerializeField] HingeJoint2D _hinge;

    // Update is called once per frame
    void Update()
    {
        TriggerPaddle(Keyboard.current.spaceKey.isPressed);
    }

    public void TriggerPaddle(bool isPressed)
    {
        _hinge.useMotor = isPressed;
    }

}
