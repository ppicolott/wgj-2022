using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLangController : MonoBehaviour
{
    public static AudioLangController current;
    public static AudioSource audioSource;
    public bool audioSystem;

    public bool english = true;
    public bool portuguese = false;
    public bool spanish = false;

    void Start()
    {
        current = this;
        audioSource = GetComponent<AudioSource>();
        audioSystem = true;
    }
}
