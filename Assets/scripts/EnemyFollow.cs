using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public float speed = 4.0f;
    [Tooltip("Number of items needed to trigger the chase")]
    public int requiredCollectibles = 10;

    private Transform playerTransform;

    private NavMeshAgent agent;
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;
        }
    }

    void Update()
    {
        // 1. Check if the GameManager exists
        // 2. Check if the player has collected enough items
        Debug.Log(Collectible.totalCollected);
        if (GameManager.Instance != null && Collectible.totalCollected >= requiredCollectibles)
        {
            ExecuteChase();
        }
    }

    void ExecuteChase()
    {
        if (playerTransform != null)
        {
           /* Vector3 direction = (playerTransform.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            // Optional 3D rotation (Remove if making a 2D game)
            transform.LookAt(new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z));*/
           agent.SetDestination (playerTransform.position);
        }
    }
}