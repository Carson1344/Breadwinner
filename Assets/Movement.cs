using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;

    void Update()
    {
        // Get input from arrow keys (or WASD)
        float moveHorizontal = Input.GetAxis("Horizontal"); // Left/Right arrows
        float moveVertical = Input.GetAxis("Vertical");     // Up/Down arrows

        // Calculate movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Move the duck position over time
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        // Optional: Rotate duck to face movement direction
        if (movement != Vector3.zero)
        {
            transform.forward = movement;
        }
    }
    }