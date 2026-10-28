using UnityEngine;
using UnityEngine.Video;

public class TVController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    // Call this from your UI Buttons, passing the specific Video Clip asset
    public void ChangeAndPlayVideo(VideoClip newClip)
    {
        if (videoPlayer != null && newClip != null)
        {
            videoPlayer.Stop();       // Stop current video
            videoPlayer.clip = newClip; // Swap to the new one
            videoPlayer.Play();       // Start playing
        }
    }

    // Optional: Add a button to go back to the main game
    public void ReturnToGame(string mainSceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(mainSceneName);
    }
}