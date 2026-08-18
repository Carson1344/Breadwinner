using UnityEngine;

public class Movement : MonoBehaviour
{
    // Adjust speed and rotation directly in the Unity Inspector
    public float moveSpeed = 5f;
    public float rotationSpeed = 720f; // Degrees per second
    private CharacterController cc;

    private void Start()
    {
        cc = GetComponent<CharacterController> ();
    }
    void Update()
    {
        // Gets WASD or Arrow Key inputs (-1 to 1)
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Calculate direction based on player input
        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        // Only move and rotate if there is actual input
        if (movement.sqrMagnitude > 0.001f)
        {
            // Move the object smoothly over time
            //transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
            cc.Move(movement * moveSpeed * Time.deltaTime);

            // Calculate the target rotation based on movement direction
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);

            // Smoothly rotate towards the target direction
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}