using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{//opens setting menu
    public void OpenSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }
    // Returns to the main menu
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
