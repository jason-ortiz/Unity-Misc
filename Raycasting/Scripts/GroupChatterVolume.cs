using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupChatterVolume : MonoBehaviour, Muteable
{
    private AudioSource m_as;
    public float m_maxDist = 10f;

    // Start is called before the first frame update
    void Start()
    {
        m_as = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var diff = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
        var ratio = 1 - Mathf.Clamp01(diff.magnitude / m_maxDist);
        m_as.volume = ratio;
    }

    public void ToggleMute()
    {
        m_as.mute = !m_as.mute;
    }
}
