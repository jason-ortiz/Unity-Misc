using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    [Tooltip("Camera attached to the player")]
    public Camera m_playerCamera;

    [Header("Container variables for the mouse delta values each frame")]
    public float m_deltaX;
    public float m_deltaY;

    private float xRot;
    private float yRot;

    [Tooltip("Mouse sensitivity level")]
    public float m_sensitivity = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        m_playerCamera = Camera.main; // Set player camera
        Cursor.visible = false; // Hide the cursor
        xRot = transform.rotation.eulerAngles.x;
        yRot = transform.rotation.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Keep track of the player's x and y rotation
        yRot += m_deltaX * m_sensitivity * Time.deltaTime;
        xRot -= m_deltaY * m_sensitivity * Time.deltaTime;

        // Keep the player's x rotation clamped [-90, 90] degrees
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        // Rotate the camera around the x-axis
        //m_playerCamera.transform.Rotate(xRot, 0, 0);
        //m_playerCamera.transform.localRotation = Quaternion.Slerp(m_playerCamera.transform.localRotation, Quaternion.Euler(xRot, 0, 0), m_sensitivity);
        m_playerCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);

        // Rotate the camera around the x-axis
        //transform.Rotate(0, yRot, 0);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yRot, 0), m_sensitivity);
        transform.rotation = Quaternion.Euler(0, yRot, 0);
    }

    // OnCameraLook Event Handler
    public void OnCameraLook(InputAction.CallbackContext context)
    {
        // Reading the mousde deltas as a 2D vector (delta X is x component and deltaY is y component)
        Vector2 inputVector = context.ReadValue<Vector2>();
        m_deltaX = inputVector.x;
        m_deltaY = inputVector.y;
    }
}
