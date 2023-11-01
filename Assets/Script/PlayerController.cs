using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float accelerationSpeed = 5.0f;
    private Rigidbody2D rb;
    public AudioSource play;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics2D.gravity = Vector2.zero;
    }

    void Update()
    {
        float horizontalInput = Input.acceleration.x;
        float verticalInput = Input.acceleration.y;

        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        movement = Vector2.ClampMagnitude(movement, 1.0f) * accelerationSpeed;

        rb.velocity = movement;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Play Sound k");
            play.Play();
        }
    }
}
