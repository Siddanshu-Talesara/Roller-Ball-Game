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
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Enter the Ball");
            other.gameObject.SetActive(false);
            backgroundMusic.Stop();
            over.Play();
            overPannel.SetActive(true);
        }
    }
}
