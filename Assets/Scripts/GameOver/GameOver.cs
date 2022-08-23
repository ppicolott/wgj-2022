using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameOver : MonoBehaviour
{
    public static bool audioPlaying = true;

    void Update()
    {
        if(Keyboard.current.anyKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame || Mouse.current.rightButton.wasPressedThisFrame ||
            Gamepad.current != null && Gamepad.current.buttonEast.wasPressedThisFrame || Gamepad.current != null && Gamepad.current.buttonSouth.wasPressedThisFrame)
        {
            if(AudioLangController.current.audioSystem)
            {
                audioPlaying = true;
            }
            else
            {
                audioPlaying = true;
            }
            AudioLangController.current.restart = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }
}
