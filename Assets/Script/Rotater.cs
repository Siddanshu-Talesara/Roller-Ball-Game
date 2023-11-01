using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // Adjust the rotation speed as needed
    private void FixedUpdate()
    {
        // Rotate the obstacle with a constant speed
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) // Make sure to tag your ball GameObject
        {
            Debug.Log("Ball Enter");
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (rb != null)
            {

                Debug.Log("Ball Enter3");
                // Calculate the force direction based on the collision point
                Vector3 forceDirection = (collision.transform.position - transform.position).normalized;

                // Apply a force to the ball
                rb.AddForce(forceDirection * 10, ForceMode2D.Impulse);
            }
        }
    }

}
