using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Victory : MonoBehaviour
{
    public TextMeshProUGUI victoryText;

    void Update()
    {
        //CheckLanguage();

        if (Keyboard.current.anyKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame || Mouse.current.rightButton.wasPressedThisFrame ||
            Gamepad.current != null && Gamepad.current.buttonEast.wasPressedThisFrame || Gamepad.current != null && Gamepad.current.buttonSouth.wasPressedThisFrame)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }

    private void CheckLanguage()
    {
        if (AudioLangController.current.english)
        {
            victoryText.text = "Victory!";
        }
        if(AudioLangController.current.portuguese)
        {
            victoryText.text = "Vitória!";
        }
        if (AudioLangController.current.spanish)
        {
            victoryText.text = "Victoria!";
        }
    }
}
