using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class GameControls : MonoBehaviour
{
    float rotationSpeed;

    void Start()
    {
        rotationSpeed = 3.5f;
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            ExitToMainMenu();
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
    }

    public void ExitToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
