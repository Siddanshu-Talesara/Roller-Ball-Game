using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverWin : MonoBehaviour
{
    public GameObject overPannel;
    public GameObject player;
    public GameObject winPannel;
    public AudioSource click;
    public void Quit()
    {
        click.Play();
        Application.Quit();     
    }
    public void Retry()
    {
        player.SetActive(true);
        click.Play();
        overPannel.SetActive(false);
        winPannel.SetActive(false);
        SceneManager.LoadScene("Play");     
    }

}
