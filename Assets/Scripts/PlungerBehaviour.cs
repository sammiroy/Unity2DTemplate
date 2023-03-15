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
        Debug.Log(_spring.distance);
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("Pull");
            _spring.distance -= 0.01f;
        }

        if (Keyboard.current.sKey.wasReleasedThisFrame)
        {
            Debug.Log("Released");
            _spring.distance = 1f;
        }
    }
}
