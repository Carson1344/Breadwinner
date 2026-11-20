using UnityEngine;

public class PersistentAudio : MonoBehaviour
{
    public static PersistentAudio Instance;
    private AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayButtonSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
