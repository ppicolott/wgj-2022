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
        }
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            DisplayTime(timer);
        }
        if (timer <= 0 || Duck.life <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
