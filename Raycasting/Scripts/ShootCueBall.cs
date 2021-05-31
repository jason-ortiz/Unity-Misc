using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootCueBall : MonoBehaviour
{
    public float m_force = 5f;
    private Rigidbody m_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        var diff = Camera.main.transform.position - m_rigidbody.position;
        var dir = -1f * Vector3.ProjectOnPlane(diff, Vector3.up).normalized;
        m_rigidbody.AddForceAtPosition(dir * m_force, m_rigidbody.position, ForceMode.Impulse);
    }
}
