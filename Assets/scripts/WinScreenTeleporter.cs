using UnityEngine;
using UnityEngine.SceneManagement; 

public class WinScreenTeleporter : MonoBehaviour
{
    // Type the exact name of your Win Screen scene in the Unity Inspector
    [SerializeField] private string winSceneName = "You win";

    // Use this if your Player has a Collider configured as a Trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the Player
        if (other.CompareTag("Player"))
        {
            LoadWinScene();
        }
    }

    // Use this if your Player has a physical, solid Collider (not a trigger)
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided is the Player
        if (collision.gameObject.CompareTag("Player"))
        {
            LoadWinScene();
        }
    }

    private void LoadWinScene()
    {
        SceneManager.LoadScene(winSceneName);
    }
}