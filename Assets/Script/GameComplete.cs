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
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Enter the Ball");
            collision.gameObject.SetActive(false);
            complete.Play();
            backgroundMusic.Stop();
            winPannel.SetActive(true);
        }
    }
}
