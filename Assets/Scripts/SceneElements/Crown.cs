using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{
    public AudioSource sucesso;
    private float timer;
    private bool nextLevel;

    private void Awake()
    {
        sucesso = GetComponent<AudioSource>();
        timer = 0.5f;
        nextLevel = false;
    }

    private void Update()
    {
        if (!AudioLangController.current.audioSystem)
        {
            sucesso.mute = true;
        }
        else
        {
            sucesso.mute = false;
        }

        if (nextLevel)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 0f;
                nextLevel = false;

                switch (Timer.current.levelNumber)
                {
                    case 1:
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelTwo");
                        break;
                    case 2:
                        UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
                        break;
                    case 3:
                        //UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
                        break;
                    case 4:
                        //UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
                        break;
                    case 5:
                        //UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
                        break;
                    case 6:
                        UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
                        break;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Head") || collision.gameObject.name.Contains("Feet"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            sucesso.Play();
            nextLevel = true;
        }
    }
}
