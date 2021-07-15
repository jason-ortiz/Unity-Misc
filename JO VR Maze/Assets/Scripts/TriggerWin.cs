using UnityEngine;

public class TriggerWin : MonoBehaviour
{
    public GameObject prizes;
    public Transform prizesParentTransform;

    private bool m_hasWon = false;
    private AudioSource m_winAudioSource;

    private void Start()
    {
        m_winAudioSource = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!m_hasWon && other.gameObject.CompareTag("MainCamera"))
        {
            m_winAudioSource.Play();
            Instantiate(prizes, prizesParentTransform);
            m_hasWon = true;
        }
    }
}
