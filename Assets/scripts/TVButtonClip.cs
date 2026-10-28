using UnityEngine;
using UnityEngine.Video;

public class TVButtonClip : MonoBehaviour
{
    public VideoClip clipToPlay;
    private TVController tvController;

    private void Start()
    {
        // Automatically finds the TVController in your scene
        tvController = Object.FindFirstObjectByType<TVController>();
    }

    // This is the function you will call from the Button Component
    public void SendVideoToTV()
    {
        if (tvController != null && clipToPlay != null)
        {
            tvController.ChangeAndPlayVideo(clipToPlay);
        }
    }
}