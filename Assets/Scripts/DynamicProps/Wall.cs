using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public static Wall current;
    public GameObject brokenWall;
    public Collider2D breakableWallCollider;
    public Sprite brokenWallSprite;
    private ParticleSystem particles;

    private void Start()
    {
        particles = GetComponent<ParticleSystem>();
        particles.Stop();
        breakableWallCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (!AudioLangController.current.audioSystem)
        {
            brokenWall.GetComponent<AudioSource>().mute = true;
        }
        else
        {
            brokenWall.GetComponent<AudioSource>().mute = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.Contains("Rock"))
        {
            breakableWallCollider.enabled = false;
            brokenWall.SetActive(true);
            particles.Play();
            GetComponent<SpriteRenderer>().sprite = brokenWallSprite;
        }
    }
}
