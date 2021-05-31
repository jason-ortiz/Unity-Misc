using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public Animator m_animator;

    private void Start()
    {
        //m_animator = gameObject.GetComponent<Animator>();
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        Animate(other, true);
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        Animate(other, false);
    }

    private void Animate(Collider other, bool isOpen)
    {
        if (other.CompareTag("Player"))
        {
            m_animator.SetBool("IsOpen", isOpen);
        }
    }


}
