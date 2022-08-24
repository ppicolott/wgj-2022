using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    float positionSpeed;

    void Start()
    {
        positionSpeed = 0.12f;
    }

    void Update()
    {
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position -= new Vector3(positionSpeed, 0, 0);
        }
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += new Vector3(positionSpeed, 0, 0);
        }
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += new Vector3(0, positionSpeed, 0);
        }
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            transform.position -= new Vector3(0, positionSpeed, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Head") || collision.gameObject.name.Contains("Feet"))
        {
            collision.gameObject.transform.localPosition = Vector3.zero;
        }
    }
}
