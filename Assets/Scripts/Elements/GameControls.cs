using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class GameControls : MonoBehaviour
{
    float rotationSpeed;

    // Vector3 mousePos;
    // Vector3 lookAt;

    void Start()
    {
        rotationSpeed = 1.1f;
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }

        if (Keyboard.current.qKey.isPressed)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z += rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationVector);

            var rotationVectorCam = GameObject.Find("Duck").transform.rotation.eulerAngles;
            rotationVectorCam.z += rotationSpeed;
            GameObject.Find("Duck").transform.rotation = Quaternion.Euler(rotationVectorCam);
        }
        if (Keyboard.current.eKey.isPressed)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z -= rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationVector);

            var rotationVectorCam = GameObject.Find("Duck").transform.rotation.eulerAngles;
            rotationVectorCam.z -= rotationSpeed;
            GameObject.Find("Duck").transform.rotation = Quaternion.Euler(rotationVectorCam);
        }

        // if (Mouse.current.rightButton.wasPressedThisFrame)
        // {
        //     mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //     lookAt = mousePos - GameObject.Find("Duck").transform.position;
        //     float angle = Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg + 15f;
        //     GetComponent<Rigidbody2D>().rotation = angle;
        //     GameObject.Find("Duck").GetComponent<Rigidbody2D>().rotation = angle;
        //     // transform.rotation = Quaternion.Euler(angle, angle, angle);
        //     // GameObject.Find("Duck").transform.rotation = Quaternion.Euler(angle, angle, angle);
        // }
    }
}
