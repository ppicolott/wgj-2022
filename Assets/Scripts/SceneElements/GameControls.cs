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
        rotationSpeed = 3.5f; //0.5f;
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

            if (Timer.current.levelNumber == 2)
            {
                var rotationVectorLaser = GameObject.Find("Laser").transform.rotation.eulerAngles;
                rotationVectorLaser.z += rotationSpeed;
                GameObject.Find("Laser").transform.rotation = Quaternion.Euler(rotationVectorLaser);
            }

            if (Timer.current.levelNumber == 4)
            {
                var rotationVectorLaserZero = GameObject.Find("Laser(0)").transform.rotation.eulerAngles;
                rotationVectorLaserZero.z += rotationSpeed;
                GameObject.Find("Laser(0)").transform.rotation = Quaternion.Euler(rotationVectorLaserZero);
            }
        }
        if (Keyboard.current.eKey.isPressed)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z -= rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationVector);

            var rotationVectorCam = GameObject.Find("Duck").transform.rotation.eulerAngles;
            rotationVectorCam.z -= rotationSpeed;
            GameObject.Find("Duck").transform.rotation = Quaternion.Euler(rotationVectorCam);

            if (Timer.current.levelNumber == 2)
            {
                var rotationVectorLaser = GameObject.Find("Laser").transform.rotation.eulerAngles;
                rotationVectorLaser.z -= rotationSpeed;
                GameObject.Find("Laser").transform.rotation = Quaternion.Euler(rotationVectorLaser);
            }

            if (Timer.current.levelNumber == 4)
            {
                var rotationVectorLaserZero = GameObject.Find("Laser(0)").transform.rotation.eulerAngles;
                rotationVectorLaserZero.z -= rotationSpeed;
                GameObject.Find("Laser(0)").transform.rotation = Quaternion.Euler(rotationVectorLaserZero);
            }
        }
    }

    public void ExitToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
