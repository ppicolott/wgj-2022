using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class GameControls : MonoBehaviour
{
    float rotationSpeed;
    float positionSpeed;

    Vector2 mousePos;
    Vector2 lookAt;
    float angle;

    void Start()
    {
        rotationSpeed = 1.1f;
        positionSpeed = 0.018f;
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

        /*
        if(Mouse.current.middleButton.isPressed)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            lookAt = mousePos - gameObject.GetComponent<Rigidbody2D>().position;
            angle = Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg + 270f;
            gameObject.GetComponent<Rigidbody2D>().rotation = angle;
        }
        */

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }

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
}
