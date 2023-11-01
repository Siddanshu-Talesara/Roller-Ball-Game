using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public GameObject door;
    public AudioSource doorOpen;
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            doorOpen.Play();
            Debug.Log("Enter in key");
            door.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
