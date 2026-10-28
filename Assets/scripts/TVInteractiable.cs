using UnityEngine;
using UnityEngine.SceneManagement;

public class TVInteractable : MonoBehaviour
{
    public string tvSceneName = "TVViewerScene";

    // Detects mouse click on the TV GameObject
    private void OnMouseDown()
    {
        TriggerSceneChange();
    }

    // Detects player walking into the TV zone
    private void OnTriggerEnter(Collider other)
    {
        // Make sure your player object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            TriggerSceneChange();
        }
    }

    private void TriggerSceneChange()
    {
        SceneManager.LoadScene(tvSceneName);
    }
}