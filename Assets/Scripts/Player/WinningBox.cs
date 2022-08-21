using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.Contains("Duck"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
        }
    }
}
