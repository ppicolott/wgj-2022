using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    float timer = 0.05f;
    private bool collided = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.name.Contains("Duck"))
        {
            collided = true;
            if(timer <= 0)
            {
                Duck.life -= 25;
                timer = 2f;
                collided = false;
            }
        }
    }

    private void Update()
    {
        if(collided)
        {
            timer -= Time.deltaTime;
        }
        Debug.Log(Duck.life);
    }
}
