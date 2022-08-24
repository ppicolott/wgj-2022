using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public static Wall current;

    public static bool hitByLaser = false;

    private Collider2D breakableWallCollider;

    public GameObject brokenWallAudio;
    public GameObject brokenWallCollider;
    public Sprite brokenWallSprite;

    private void Start()
    {
        breakableWallCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (!AudioLangController.current.audioSystem)
        {
            if (brokenWallAudio.activeInHierarchy)
            {
                brokenWallAudio.GetComponent<AudioSource>().mute = true;
            }
        }
        else
        {
            if (brokenWallAudio.activeInHierarchy)
            {
                brokenWallAudio.GetComponent<AudioSource>().mute = false;
            }
        }

        if (hitByLaser)
        {
            HitByLaser();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.Contains("Rock"))
        {
            breakableWallCollider.enabled = false;
            brokenWallCollider.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = brokenWallSprite;
        }
    }
    
    public void HitByLaser()
    {
        breakableWallCollider.enabled = false;
        brokenWallCollider.SetActive(true);
        GetComponent<SpriteRenderer>().sprite = brokenWallSprite;
        hitByLaser = false;
    }
}
