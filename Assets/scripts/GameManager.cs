using UnityEngine;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Static instance allows any other script to access this easily
    public static GameManager Instance { get; private set; }

    public int totalCollectibles = 0;

    void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(gameObject); }
    }

    public void AddCollectible()
    {
        totalCollectibles++;
        Debug.Log("Items Collected: " + totalCollectibles);
    }
}