using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    public static Mover current;
    public float positionSpeed;

    private void Start()
    {
        positionSpeed = 0.12f;
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position -= new Vector3(positionSpeed, 0, 0);

            GameObject.Find("DuckSprite").gameObject.GetComponent<SpriteRenderer>().flipX = true;

            if (GameObject.Find("DuckFollower") != null)
            {
                GameObject.Find("DuckFollower").gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }

            if (GameObject.Find("DuckFollower(0)") != null)
            {
                GameObject.Find("DuckFollower(0)").gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }

            if (GameObject.Find("DuckFollower(1)") != null)
            {
                GameObject.Find("DuckFollower(1)").gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += new Vector3(positionSpeed, 0, 0);

            GameObject.Find("DuckSprite").gameObject.GetComponent<SpriteRenderer>().flipX = false;

            if (GameObject.Find("DuckFollower") != null)
            {
                GameObject.Find("DuckFollower").gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (GameObject.Find("DuckFollower(0)") != null)
            {
                GameObject.Find("DuckFollower(0)").gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (GameObject.Find("DuckFollower(1)") != null)
            {
                GameObject.Find("DuckFollower(1)").gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
        }
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += new Vector3(0, positionSpeed, 0);
        }
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            transform.position -= new Vector3(0, positionSpeed, 0);
        }
    }
}
