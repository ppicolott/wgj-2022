using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerControls : MonoBehaviour
{
    private Controllers controllers;

    public float rotationSpeed;
    public float positionSpeed;

    Vector2 movement;
    float test;

    Vector2 left;
    Vector2 right;
    Vector2 up;
    Vector2 down;

    Vector3 pos;

    void Awake()
    {
        controllers = new Controllers();

        left = new Vector2(-1, 0);
        right = new Vector2(1, 0);
        up = new Vector2(0, 1);
        down = new Vector2(0, -1);

        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    void Start()
    {
        rotationSpeed = 0.05f;
        positionSpeed = 2f;
    }

    void Update()
    {
        // if (Keyboard.current.aKey.isPressed)
        // {
        //     var rotationVector = transform.rotation.eulerAngles;
        //     rotationVector.z += speed;
        //     transform.rotation = Quaternion.Euler(rotationVector);
        // }
        // if (Keyboard.current.dKey.isPressed)
        // {
        //     var rotationVector = transform.rotation.eulerAngles;
        //     rotationVector.z -= speed;
        //     transform.rotation = Quaternion.Euler(rotationVector);
        // }
    }
    private void OnEnable()
    {
        controllers.Enable();

        controllers.Player.Move.performed += Move;
        //controllers.Player.Rotate.performed += Rotate;
    }
    private void OnDisable()
    {
        controllers.Player.Move.performed -= Move;
        //controllers.Player.Rotate.performed -= Rotate;

        controllers.Disable();
    }

    private void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();

        // if (movement == left)
        // {
        //     positionSpeed = 0.01f;
        //     transform.position -= new Vector3(positionSpeed, 0, 0);
        // }
        // if (movement == right)
        // {
        //     positionSpeed = 0.01f;
        //     transform.position += new Vector3(positionSpeed, 0, 0);
        // }
        // if (movement == up)
        // {
        //     positionSpeed = 0.01f;
        //     transform.position += new Vector3(0, positionSpeed, 0);
        // }
        // if (movement == down)
        // {
        //     positionSpeed = 0.01f;
        //     transform.position -= new Vector3(0, positionSpeed, 0);
        // }
    }

    private void Rotate(InputAction.CallbackContext context)
    {
        test = context.ReadValue<float>();
    }
}