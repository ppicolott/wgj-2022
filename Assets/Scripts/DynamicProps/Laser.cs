using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform firePoint;
    public LineRenderer lineRenderer;
    private float distance;
    RaycastHit2D[] targetPoint;
    private int breakWall;

    private void Start()
    {
        lineRenderer.sortingOrder = -1;
    }

    private void Update()
    {
        if (Timer.current.levelNumber == 5)
        {
            if (breakWall == 1)
            {
                GameObject.Find("BreakableWall(3)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                GameObject.Find("BreakableWall(3)").GetComponent<Wall>().brokenWall.SetActive(true);
                GameObject.Find("BreakableWall(3)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(3)").GetComponent<Wall>().brokenWallSprite;
            }
            if (breakWall == 2)
            {
                GameObject.Find("BreakableWall(2)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                GameObject.Find("BreakableWall(2)").GetComponent<Wall>().brokenWall.SetActive(true);
                GameObject.Find("BreakableWall(2)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(2)").GetComponent<Wall>().brokenWallSprite;
            }
            if (breakWall == 3)
            {
                GameObject.Find("BreakableWall(1)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                GameObject.Find("BreakableWall(1)").GetComponent<Wall>().brokenWall.SetActive(true);
                GameObject.Find("BreakableWall(1)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(1)").GetComponent<Wall>().brokenWallSprite;
            }
        }
    }

    private IEnumerator LaserBeam(float distance)
    {
        targetPoint = Physics2D.RaycastAll(firePoint.position, firePoint.up);

        for (int i = 0; i < targetPoint.Length; i++)
        {
            RaycastHit2D hit = targetPoint[i];

            if (hit)
            {
                lineRenderer.sortingOrder = 3;
                lineRenderer.SetPosition(0, firePoint.position);
                lineRenderer.SetPosition(1, new Vector2(firePoint.position.x, firePoint.position.y + distance));

                if (Timer.current.levelNumber == 2)
                {
                    if (hit.collider.gameObject.name.Contains("Breakable") && distance > 0)
                    {
                        GameObject.Find("BreakableWall").GetComponent<Wall>().breakableWallCollider.enabled = false;
                        GameObject.Find("BreakableWall").GetComponent<Wall>().brokenWall.SetActive(true);
                        GameObject.Find("BreakableWall").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall").GetComponent<Wall>().brokenWallSprite;
                    }
                }
                if (Timer.current.levelNumber == 4)
                {
                    Debug.Log(hit.collider.gameObject.name);
                    if (hit.collider.gameObject.name.Contains("Breakable") && distance < 0)
                    {
                        if (gameObject.name.Equals("Laser(0)"))
                        {
                            GameObject.Find("BreakableWall(3)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                            GameObject.Find("BreakableWall(3)").GetComponent<Wall>().brokenWall.SetActive(true);
                            GameObject.Find("BreakableWall(3)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(3)").GetComponent<Wall>().brokenWallSprite;
                        }
                        if (gameObject.name.Equals("Laser(1)"))
                        {
                            GameObject.Find("BreakableWall(0)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                            GameObject.Find("BreakableWall(0)").GetComponent<Wall>().brokenWall.SetActive(true);
                            GameObject.Find("BreakableWall(0)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(0)").GetComponent<Wall>().brokenWallSprite;
                        }
                    }
                }
                if (Timer.current.levelNumber == 5)
                {
                    if (hit.collider.gameObject.name.Contains("Breakable") && distance < 0)
                    {
                        if (GameObject.Find("BreakableWall(3)").gameObject.GetComponent<PolygonCollider2D>().enabled)
                        {
                            breakWall = 1;
                        }
                        else if (GameObject.Find("BreakableWall(2)").gameObject.GetComponent<PolygonCollider2D>().enabled)
                        {
                            breakWall = 2;
                        }
                        else if (GameObject.Find("BreakableWall(1)").gameObject.GetComponent<PolygonCollider2D>().enabled)
                        {
                            breakWall = 3;
                        }
                    }
                }
                if (Timer.current.levelNumber == 6)
                {
                    if (hit.collider.gameObject.name.Contains("Breakable") && distance > 0)
                    {
                        if (gameObject.name.Equals("Laser(2)"))
                        {
                            GameObject.Find("BreakableWall(6)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                            GameObject.Find("BreakableWall(6)").GetComponent<Wall>().brokenWall.SetActive(true);
                            GameObject.Find("BreakableWall(6)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(6)").GetComponent<Wall>().brokenWallSprite;
                        }
                        if (gameObject.name.Equals("Laser(1)"))
                        {
                            GameObject.Find("BreakableWall(4)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                            GameObject.Find("BreakableWall(4)").GetComponent<Wall>().brokenWall.SetActive(true);
                            GameObject.Find("BreakableWall(4)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(4)").GetComponent<Wall>().brokenWallSprite;
                        }
                        if (gameObject.name.Equals("Laser(0)"))
                        {
                            if (hit.collider.gameObject.name.Equals("BreakableWall(5)"))
                            {
                                GameObject.Find("BreakableWall(5)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                                GameObject.Find("BreakableWall(5)").GetComponent<Wall>().brokenWall.SetActive(true);
                                GameObject.Find("BreakableWall(5)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(5)").GetComponent<Wall>().brokenWallSprite;
                            }
                            if (hit.collider.gameObject.name.Equals("BreakableWall(1)"))
                            {
                                GameObject.Find("BreakableWall(1)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                                GameObject.Find("BreakableWall(1)").GetComponent<Wall>().brokenWall.SetActive(true);
                                GameObject.Find("BreakableWall(1)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(1)").GetComponent<Wall>().brokenWallSprite;
                            }
                            if (hit.collider.gameObject.name.Equals("BreakableWall(2)"))
                            {
                                GameObject.Find("BreakableWall(2)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                                GameObject.Find("BreakableWall(2)").GetComponent<Wall>().brokenWall.SetActive(true);
                                GameObject.Find("BreakableWall(2)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(2)").GetComponent<Wall>().brokenWallSprite;
                            }
                        }
                    }
                }
                else
                {
                    lineRenderer.SetPosition(0, firePoint.position);
                    lineRenderer.SetPosition(1, new Vector2(firePoint.position.x, firePoint.position.y + distance));
                }
            }

            lineRenderer.enabled = true;

            yield return new WaitForSeconds(0.05f);

            lineRenderer.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Timer.current.levelNumber == 2 || Timer.current.levelNumber == 6)
        {
            if (collision.gameObject.transform.position.y >= transform.position.y)
            {
                distance = -2.5f;
                StartCoroutine(LaserBeam(distance));
            }
            if (collision.gameObject.transform.position.y <= transform.position.y)
            {
                distance = 2.5f;
                StartCoroutine(LaserBeam(distance));
            }
        }
        if (Timer.current.levelNumber == 4 || Timer.current.levelNumber == 5)
        {
            if (collision.gameObject.transform.position.y >= transform.position.y)
            {
                distance = -10f;
                StartCoroutine(LaserBeam(distance));
            }
            if (collision.gameObject.transform.position.y <= transform.position.y)
            {
                distance = 10f;
                StartCoroutine(LaserBeam(distance));
            }
        }
    }
}
