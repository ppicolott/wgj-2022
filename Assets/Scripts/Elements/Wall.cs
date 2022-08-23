using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Collider2D breakableWallCollider;

    public GameObject brokenWallCollider;
    public Sprite brokenWallSprite;

    private void Start()
    {
        breakableWallCollider = GetComponent<Collider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.Contains("Rock"))
        {
            breakableWallCollider.enabled = false;
            // brokenWallCollider.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = brokenWallSprite;

            // if (collision.collider.gameObject.GetComponent<Rigidbody2D>().velocity.x > 0 ||
            //     collision.collider.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0)
            // {
            // }
        }
    }
}
