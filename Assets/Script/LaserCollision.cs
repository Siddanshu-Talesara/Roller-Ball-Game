using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCollision : MonoBehaviour
{
    public GameObject overPannel;
    public AudioSource laser;
    public AudioSource backgroundMusic;
    public AudioSource over;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the laser collides with the ball
        if (collision.gameObject.CompareTag("Ball"))
        {
            laser.Play();
            over.Play();
            Debug.Log("Enter the Ball");
            // Destroy the ball
            collision.gameObject.SetActive(false);
            backgroundMusic.Stop();
            overPannel.SetActive(true);
        }
    }
}
