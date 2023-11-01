using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Play");
    }
    public void QuitGame()
    {
        // Quit the application when the Quit button is clicked
        Application.Quit();
    }
}
