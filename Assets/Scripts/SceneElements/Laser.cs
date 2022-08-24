using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform firePoint;
    public LineRenderer lineRenderer;
    private float distance;

    private IEnumerator LaserBeamUp(float distance)
    {
        RaycastHit2D[] targetPoint = Physics2D.RaycastAll(firePoint.position, firePoint.up);
        for (int i = 0; i < targetPoint.Length; i++)
        {
            RaycastHit2D hit = targetPoint[i];

            if (hit)
            {
                lineRenderer.SetPosition(0, firePoint.position);
                lineRenderer.SetPosition(1, new Vector2(firePoint.position.x, firePoint.position.y + distance));

                if (hit.collider.gameObject.name.Contains("Breakable"))
                {
                    Wall.hitByLaser = true;
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

    private IEnumerator LaserBeamDown(float distance)
    {
        lineRenderer.SetPosition(0, firePoint.position);
        lineRenderer.SetPosition(1, new Vector2(firePoint.position.x, firePoint.position.y + distance));

        lineRenderer.enabled = true;

        yield return new WaitForSeconds(0.05f);

        lineRenderer.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.position.y >= transform.position.y)
        {
            distance = -2.5f;
            StartCoroutine(LaserBeamDown(distance));
        }
        if (collision.gameObject.transform.position.y <= transform.position.y)
        {
            distance = 2.5f;
            StartCoroutine(LaserBeamUp(distance));
        }
    }
}
