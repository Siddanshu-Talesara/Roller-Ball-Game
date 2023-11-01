using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour
{
    public AudioSource complete;
    public AudioSource backgroundMusic;
    public GameObject winPannel;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the laser collides with the ball
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Enter the Ball");
            // Destroy the ball
            collision.gameObject.SetActive(false);
            complete.Play();
            backgroundMusic.Stop();
            winPannel.SetActive(true);
        }
    }
}
