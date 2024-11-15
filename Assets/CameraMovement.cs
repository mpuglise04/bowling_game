using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 10f; // Speed of the camera movement

    void Update()
    {
        // Get input from WASD or arrow keys
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Calculate direction based on input
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // Move the camera
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }
}
