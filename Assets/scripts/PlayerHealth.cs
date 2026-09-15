using UnityEngine;
using UnityEngine.SceneManagement; 
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    // Type the EXACT name of your Game Over scene in the Inspector
    public string Gameover= "GameOver";

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player has died! Loading Game Over scene...");

        // 3. This line triggers the scene swap
        SceneManager.LoadScene(Gameover);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
           TakeDamage(1);
    }
}