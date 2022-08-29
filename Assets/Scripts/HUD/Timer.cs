using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Timer : MonoBehaviour
{
    public static Timer current;
    public int levelNumber;
    private float timer;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI chancesText;

    private void Start()
    {
        current = this;

        switch (levelNumber)
        {
            case 1:
                timer = 30f;
                break;
            case 2:
                timer = 30f;
                break;
            case 3:
                timer = 45f;
                break;
            case 4:
                timer = 40f;
                break;
            case 5:
                timer = 70f;
                break;
            case 6:
                timer = 150f;
                break;
        }
    }

    private void Update()
    {
        chancesText.text = Duck.chances.ToString() + "x";

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            DisplayTime(timer);
        }
        if (timer <= 0 || Duck.life <= 0)
        {
            if (Duck.chances == 2)
            {
                Duck.chances = 1;
                switch (levelNumber)
                {
                    case 1:
                        Duck.life = 75;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelOne");
                        break;
                    case 2:
                        Duck.life = 75;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelTwo");
                        break;
                    case 3:
                        Duck.life = 75;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelThree");
                        break;
                    case 4:
                        Duck.life = 75;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelFour");
                        break;
                    case 5:
                        Duck.life = 75;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelFive");
                        break;
                    case 6:
                        Duck.life = 75;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSix");
                        break;
                }
            }
            else if (Duck.chances == 1)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
