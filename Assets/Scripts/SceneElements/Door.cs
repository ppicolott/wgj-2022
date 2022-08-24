using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    float rotationSpeed = 5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.Contains("Head") || collision.collider.gameObject.name.Contains("Feet"))
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z -= rotationSpeed;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
    }
}
