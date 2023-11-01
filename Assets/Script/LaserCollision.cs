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
       
        if (collision.gameObject.CompareTag("Ball"))
        {
            laser.Play();
            over.Play();
            Debug.Log("Enter the Ball");
            collision.gameObject.SetActive(false);
            backgroundMusic.Stop();
            overPannel.SetActive(true);
        }
    }
}
