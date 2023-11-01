using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{
    public GameObject overPannel;
    public AudioSource backgroundMusic;
    public AudioSource over;

    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the laser collides with the ball
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Enter the Ball");
            // Destroy the ball
            other.gameObject.SetActive(false);
            backgroundMusic.Stop();
            over.Play();
            overPannel.SetActive(true);
        }
    }
}
