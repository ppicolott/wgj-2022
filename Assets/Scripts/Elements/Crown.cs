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
        if(nextLevel)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 0f;
                nextLevel = false;
                UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sucesso.Play();
        nextLevel = true;
    }
}
