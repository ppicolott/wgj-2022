using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class LanguageSelector : MonoBehaviour
{
    public static LanguageSelector current;

    private int selector;

    public GameObject languageCanvas;
    public GameObject mainMenuCanvas;

    public GameObject englishButton;
    public GameObject portugueseButton;
    public GameObject spanishButton;

    void Start()
    {
        current = this;
        selector = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame || Keyboard.current.leftArrowKey.wasPressedThisFrame ||
            Gamepad.current != null && Gamepad.current.dpad.left.wasPressedThisFrame)
        {
            if (selector <= 0)
            {
                selector = 2;
            }
            else
            {
                selector -= 1;
            }
        }

        if (Keyboard.current.dKey.wasPressedThisFrame || Keyboard.current.rightArrowKey.wasPressedThisFrame ||
             Gamepad.current != null && Gamepad.current.dpad.right.wasPressedThisFrame)
        {
            if (selector >= 2)
            {
                selector = 0;
            }
            else
            {
                selector += 1;
            }
        }

        if (selector == 0)
        {
            EventSystem.current.SetSelectedGameObject(englishButton);
            if (Keyboard.current.enterKey.wasPressedThisFrame || Keyboard.current.numpadEnterKey.wasPressedThisFrame ||
                Keyboard.current.spaceKey.wasPressedThisFrame || Gamepad.current != null && Gamepad.current.buttonSouth.wasPressedThisFrame)
            {
                EnglishLanguage();
            }
        }
        else if (selector == 1)
        {
            EventSystem.current.SetSelectedGameObject(portugueseButton);
            if (Keyboard.current.enterKey.wasPressedThisFrame || Keyboard.current.numpadEnterKey.wasPressedThisFrame ||
                Keyboard.current.spaceKey.wasPressedThisFrame || Gamepad.current != null && Gamepad.current.buttonSouth.wasPressedThisFrame)
            {
                PortugueseLanguage();
            }
        }
        if (selector == 2)
        {
            EventSystem.current.SetSelectedGameObject(spanishButton);
            if (Keyboard.current.enterKey.wasPressedThisFrame || Keyboard.current.numpadEnterKey.wasPressedThisFrame ||
                Keyboard.current.spaceKey.wasPressedThisFrame || Gamepad.current != null && Gamepad.current.buttonSouth.wasPressedThisFrame)
            {
                SpanishLanguage();
            }
        }
    }

    public void EnglishLanguage()
    {
        AudioLangController.current.english = true;
        AudioLangController.current.portuguese = false;
        AudioLangController.current.spanish = false;
        languageCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
    public void PortugueseLanguage()
    {
        AudioLangController.current.english = false;
        AudioLangController.current.portuguese = true;
        AudioLangController.current.spanish = false;
        languageCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
    public void SpanishLanguage()
    {
        AudioLangController.current.english = false;
        AudioLangController.current.portuguese = false;
        AudioLangController.current.spanish = true;
        languageCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
}
