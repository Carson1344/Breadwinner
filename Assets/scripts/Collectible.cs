using UnityEngine;


public class Collectible : MonoBehaviour
{
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
            // Add custom player logic here (e.g., increase score)

            // Remove the collectible from the scene
            Destroy(gameObject);
        }

    }
}