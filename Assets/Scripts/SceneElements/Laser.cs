using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform firePoint;
    public LineRenderer lineRenderer;
    private float distance;
    RaycastHit2D[] targetPoint;

    private IEnumerator LaserBeamUp(float distance)
    {
        if (Timer.current.levelNumber == 2)
        {
            targetPoint = Physics2D.RaycastAll(firePoint.position, firePoint.up);
        }
        if (Timer.current.levelNumber == 4)
        {
            targetPoint = Physics2D.RaycastAll(firePoint.position, firePoint.right);
        }

        for (int i = 0; i < targetPoint.Length; i++)
        {
            RaycastHit2D hit = targetPoint[i];

            if (hit)
            {
                lineRenderer.SetPosition(0, firePoint.position);
                lineRenderer.SetPosition(1, new Vector2(firePoint.position.x, firePoint.position.y + distance));

                if (Timer.current.levelNumber == 2)
                {
                    if (hit.collider.gameObject.name.Contains("Breakable") && distance > 0)
                    {
                        GameObject.Find("BreakableWall").GetComponent<Wall>().breakableWallCollider.enabled = false;
                        GameObject.Find("BreakableWall").GetComponent<Wall>().brokenWallCollider.SetActive(true);
                        GameObject.Find("BreakableWall").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall").GetComponent<Wall>().brokenWallSprite;
                    }
                }
                if (Timer.current.levelNumber == 4)
                {

                    if (hit.collider.gameObject.name.Contains("Breakable") && distance < 0)
                    {
                        GameObject.Find("BreakableWall(3)").GetComponent<Wall>().breakableWallCollider.enabled = false;
                        GameObject.Find("BreakableWall(3)").GetComponent<Wall>().brokenWallCollider.SetActive(true);
                        GameObject.Find("BreakableWall(3)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("BreakableWall(3)").GetComponent<Wall>().brokenWallSprite;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.position.y >= transform.position.y)
        {
            distance = -2.5f;
            StartCoroutine(LaserBeamUp(distance));
        }
        if (collision.gameObject.transform.position.y <= transform.position.y)
        {
            distance = 2.5f;
            StartCoroutine(LaserBeamUp(distance));
        }
    }
}
