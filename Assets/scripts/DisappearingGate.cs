using UnityEngine;

public class DisappearingBlock : MonoBehaviour
{
    public int requiredAmount = 5; // How many items needed

    void Update()
    {
        // Check if player collected enough items
        if (Collectible.totalCollected >= requiredAmount)
        {
            gameObject.SetActive(false); // Disables the block
        }
    }
}