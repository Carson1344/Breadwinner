using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int attackDamage = 1; // Set to 1 for instant kill

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the enemy collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(attackDamage);
            }
        }
    }
    
}

  
  