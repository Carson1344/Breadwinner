using UnityEngine;


public class Collectible : MonoBehaviour
{
    internal static int totalCollected;

    private void Start()
    {
        totalCollected = 0;
    }

    // Optional visual juice: Rotate the object over time
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
    }

    // Detect when another physics body enters the trigger space
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // NEW: Find the HUD manager and add to the counter
            HUDManager hud = FindFirstObjectByType<HUDManager>();
            totalCollected++; 
            if (hud != null)
            {
                hud.AddCollectible();
            }
            // Remove the collectible from the scene
            Destroy(gameObject);
        }

    }
}