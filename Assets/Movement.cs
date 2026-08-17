using UnityEngine;

public class Movement : MonoBehaviour
{
    // Adjust speed directly in the Unity Inspector
    public float moveSpeed = 5f;

    void Update()
    {
        // Gets WASD or Arrow Key inputs (-1 to 1)
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Calculate direction based on player input
        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        // Move the object smoothly over time
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);


    }
}