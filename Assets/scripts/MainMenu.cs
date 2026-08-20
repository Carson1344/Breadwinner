using UnityEngine;
using UnityEngine.SceneManagement; // Required for changing scenes

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Loads the next scene in the build queue
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        // Closes the application (Only works in a built executable)
        Debug.Log("Player has quit the game.");
        Application.Quit();
    }
}
