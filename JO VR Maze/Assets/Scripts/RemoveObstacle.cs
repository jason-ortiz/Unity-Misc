using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RemoveObstacle : MonoBehaviour
{
    private bool m_wasRemoved = false;
    
    //private void OnTriggerEnter(Collider other)
    //{
    //    Physics.ComputePenetration()
    //    other.
    //    if (!m_wasRemoved && other.gameObject.CompareTag("Chainsaw"))
    //    {
    //        // Remove obstacle
    //        gameObject.SetActive(false);
    //        m_wasRemoved = true;
    //    }
    //}

    public void RemoveObstacleOnActivate(ActivateEventArgs args)
    {
        GameObject chainSaw = gameObject;
        GameObject obstacle = GameObject.FindGameObjectWithTag("Obstacle");

        bool isOverlapped = Physics.ComputePenetration(
            chainSaw.GetComponent<Collider>(),
            chainSaw.transform.position,
            chainSaw.transform.rotation,
            obstacle.GetComponent<Collider>(),
            obstacle.transform.position,
            obstacle.transform.rotation,
            out Vector3 _,
            out float _);
        Debug.Log($"isOverlapped: {isOverlapped}");
        if (!m_wasRemoved && isOverlapped)
        {
            obstacle.SetActive(false);
            m_wasRemoved = true;
        }
    }
}
