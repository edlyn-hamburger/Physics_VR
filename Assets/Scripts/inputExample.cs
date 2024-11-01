using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI; 

public class inputExample : MonoBehaviour
{
    private XRIDefaultInputActions controller;
    public TextMeshProUGUI rotationText;

    // Start is called before the first frame update
    private void Awake()
    {
        // Initialize the input actions
        controller = new XRIDefaultInputActions();
    }

    private void OnEnable()
    {
        controller.Enable(); // Enable the input actions

        // Register to the rotate action performed event
        controller.XRILeftHand.Rotation.performed += OnRotatePerformed;
    }

    private void OnDisable()
    {
        // Unregister the event when not needed
        controller.XRILeftHand.Rotation.performed -= OnRotatePerformed;
        controller.Disable(); // Disable the input actions
    }

    private void OnRotatePerformed(InputAction.CallbackContext context)
    {
        // Get the rotation input as a Quaternion
        Quaternion rotationInput = context.ReadValue<Quaternion>();

        // Convert the quaternion to Euler angles for easier display
        Vector3 controllerRotation = rotationInput.eulerAngles;

        // Format the rotation input to display
        rotationText.text = $"Controller Rotation: {controllerRotation}";
    }
}
