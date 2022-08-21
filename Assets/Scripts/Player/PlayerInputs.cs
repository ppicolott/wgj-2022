using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    Rigidbody2D rigidBody;

    float rotationSpeed;
    float positionSpeed;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        rotationSpeed = 0.05f;
        positionSpeed = 0.005f;
    }

    void Update()
    {
        if (Keyboard.current.qKey.isPressed)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z += rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
        if (Keyboard.current.eKey.isPressed)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z -= rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationVector);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            transform.position += new Vector3(positionSpeed, 0, 0);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.position -= new Vector3(positionSpeed, 0, 0);
        }
        if (Keyboard.current.wKey.isPressed)
        {
            transform.position -= new Vector3(0, positionSpeed, 0);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.position += new Vector3(0, positionSpeed, 0);
        }
    }
}
