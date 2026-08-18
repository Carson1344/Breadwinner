using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90f;
    public float rotationSpeed = 3f;

    private bool isOpen = false;
    private bool isPlayerNearby = false;

    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        // Save the starting rotation and calculate target open rotation
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0, openAngle, 0));
    }

    void Update()
    {
        // Check if player is in range and presses the 'E' key
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
        }

        // Smoothly rotate toward the target orientation
        Quaternion targetRotation = isOpen ? openRotation : closedRotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
        }
    }
}