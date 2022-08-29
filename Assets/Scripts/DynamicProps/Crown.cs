using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{
    public AudioSource sucesso;
    public GameObject crownParticles;
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
                        Duck.life = 75;
                        Duck.chances = 2;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelTwo");
                        break;
                    case 2:
                        Duck.life = 75;
                        Duck.chances = 2;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelThree");
                        break;
                    case 3:
                        Duck.life = 75;
                        Duck.chances = 2;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelFour");
                        break;
                    case 4:
                        Duck.life = 75;
                        Duck.chances = 2;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelFive");
                        break;
                    case 5:
                        Duck.life = 75;
                        Duck.chances = 2;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSix");
                        break;
                    case 6:
                        Duck.life = 75;
                        Duck.chances = 2;
                        UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
                        break;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("DuckCollider"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            crownParticles.SetActive(false);
            sucesso.Play();
            nextLevel = true;
        }
    }
}
