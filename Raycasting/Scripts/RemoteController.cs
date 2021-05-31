using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class RemoteController : MonoBehaviour
{
    private Transform m_playerTransform;
    private Transform m_pickupSlotTransform;
    private Image m_cursor;
    private Vector3 m_defaultPos;
    private Quaternion m_defaultRot;
    private GameObject m_hitObject;

    private bool m_remoteIsHeld = false;

    // Start is called before the first frame update
    void Start()
    {
        m_cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<Image>();
        m_cursor.gameObject.SetActive(false);

        m_pickupSlotTransform = GameObject.FindGameObjectWithTag("PickupSlot").transform;
        m_playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        m_defaultPos = transform.position;
        m_defaultRot = transform.rotation;

    }

    void FixedUpdate()
    {

        var cameraRay = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        if (m_remoteIsHeld)
        {
            if (Physics.Raycast(cameraRay, out RaycastHit hit) && hit.collider.CompareTag("Muteable"))
            {
                m_cursor.color = Color.green;
                m_hitObject = hit.collider.gameObject;
            }
            else
            {
                m_cursor.color = Color.white;
                m_hitObject = null;
            }
        }
    }

    public void OnPickup(InputAction.CallbackContext context)
    {
        var dist = (m_playerTransform.position - transform.position).magnitude;
        if (!context.started)
        {
            if (!m_remoteIsHeld && dist <= 1f)
            {
                m_remoteIsHeld = true;
                transform.SetParent(m_pickupSlotTransform.transform);
                transform.position = m_pickupSlotTransform.position;
                transform.rotation = m_pickupSlotTransform.rotation;
            }
            else
            {
                transform.parent = null;
                transform.SetPositionAndRotation(m_defaultPos, m_defaultRot);
                m_remoteIsHeld = false;
            }
            m_cursor.gameObject.SetActive(m_remoteIsHeld);
        }
    }
    public void OnRemoteControl(InputAction.CallbackContext context)
    {
        if (!context.started && !MenuControl.GamePaused)
        {
            if (m_hitObject != null)
            {
                m_hitObject.GetComponent<Muteable>().ToggleMute();
            }
        }
    }
    public void OnMenuControl(InputAction.CallbackContext context)
    {
        if (!context.started)
        {
            m_cursor.gameObject.SetActive(!MenuControl.GamePaused && m_remoteIsHeld);
        }
    }
}
