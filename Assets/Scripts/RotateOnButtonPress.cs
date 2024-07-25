using UnityEngine;

public class RotateOnButtonPress : MonoBehaviour
{
    // Rotation speed in degrees per second
    public float rotationSpeed = 45f;

    // Key to press for rotating the object
    public KeyCode rotateKey = KeyCode.R;

    void Update()
    {
        // Check if the rotate key is pressed
        if (Input.GetKeyDown(rotateKey))
        {
            // Rotate the object around the X-axis by the specified amount
            transform.Rotate(rotationSpeed, 0, 0);
        }
    }
}
