using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Animation : MonoBehaviour
{
    public Animator anim;

    Vector3 left;
    Vector3 right;

    void Start()
    {
        left = transform.localScale;
        right = new Vector3(transform.localScale.x * -1f, transform.localScale.y * 1f, transform.localScale.z * 1f);
    }

    void Update()
    {
        if (!Keyboard.current.anyKey.isPressed)
        {
            anim.SetFloat("speed", -0.1f);
            transform.localScale = left;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            anim.SetFloat("speed", 0.1f);
            anim.SetBool("west", true);
            transform.localScale = left;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            anim.SetFloat("speed", 0.1f);
            anim.SetBool("west", true);
            transform.localScale = right;
        }
    }
}
