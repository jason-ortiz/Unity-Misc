using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Oscillate : MonoBehaviour
{
    public float rotationSpeed = 2.5f;
    public float oscillateSpeed = 2.5f;
    public float oscillateAmplitude = 0.5f;

    private bool wasPickedUp = false;
    private Vector3 maxPos;
    private Vector3 minPos;

    private void Start()
    {
        maxPos = transform.position + Vector3.up * oscillateAmplitude;
        minPos = transform.position - Vector3.up * oscillateAmplitude;
    }

    private void FixedUpdate()
    {
        if (!wasPickedUp)
        {
            // Rotate
            transform.Rotate(Vector3.up, rotationSpeed);

            // Oscillate up and down
            float pos = Mathf.PingPong(Time.time * Time.fixedDeltaTime * oscillateSpeed, 1);
            if (transform.parent == null)
                transform.position = Vector3.Lerp(minPos, maxPos, pos);
            else
                transform.localPosition = Vector3.Lerp(minPos, maxPos, pos);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!wasPickedUp && other.gameObject.CompareTag("GameController"))
        {
            wasPickedUp = true;

        }
    }

    public void OnSelectExit(SelectExitEventArgs args)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false; // allow gravity to control object
    }
}
