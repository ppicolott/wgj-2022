using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLangController : MonoBehaviour
{
    public static AudioLangController current;
    public static AudioSource audioSource;
    public bool audioSystem = true;
    public bool restart = false;

    public bool english = true;
    public bool portuguese = false;
    public bool spanish = false;

    private void Awake()
    {
        current = this;
        audioSystem = true;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    private void Update()
    {
        if (restart && Victory.audioPlaying || restart && GameOver.audioPlaying)
        {
            audioSystem = false;
            audioSource.Stop();
        }
        if (restart && !Victory.audioPlaying || restart && !GameOver.audioPlaying)
        {
            audioSystem = true;
            audioSource.Stop();
        }
    }
}
