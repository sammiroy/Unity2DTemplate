using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlungerBehaviour : MonoBehaviour
{
    [SerializeField] SpringJoint2D _spring;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.sKey.isPressed)
        {
            _spring.distance += 0.01f;
        }

        if (Keyboard.current.sKey.wasReleasedThisFrame)
        {
            _spring.distance = 0f;
        }
    }
}
