using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    [Header("Player's movement params")]
    public Vector3 m_direction;
    public float m_speed;

    private CharacterController m_controller;
    private float gravityValue = -9.81f;

    private void Start()
    {
        m_controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        //transform.Translate(m_direction * m_speed * Time.deltaTime);
        Vector3 localDirection = transform.TransformDirection(m_direction);
        m_controller.Move(localDirection * m_speed * Time.deltaTime);
    }

    // OnPlayerMove Event Handler
    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        // A vector with x and y components corresponding to the player's WASD and arrow inputs
        // both components are in the range [-1, 1]
        Vector2 inputVector = context.ReadValue<Vector2>();

        // Move in the XZ-plane
        m_direction.x = inputVector.x;
        m_direction.z = inputVector.y;
        m_direction.y = gravityValue;
    }
}
