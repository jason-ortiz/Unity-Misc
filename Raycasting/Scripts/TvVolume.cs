using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.Video;

public class TvVolume : MonoBehaviour, Muteable
{
    private VideoPlayer m_vp;
    private Toggle m_muteToggle;
    public float m_maxDist = 10f;

    // Start is called before the first frame update
    void Start()
    {
        m_vp = gameObject.GetComponent<VideoPlayer>();
        m_muteToggle = GameObject.FindGameObjectWithTag("MuteToggle").GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        var diff = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
        var ratio = 1 - Mathf.Clamp01(diff.magnitude / m_maxDist);
        m_vp.SetDirectAudioVolume(0, ratio);
    }

    public void ToggleMute()
    {
        m_muteToggle.isOn = !m_muteToggle.isOn;
    }

    public void ToggleTvMute(bool state)
    {
        m_vp.SetDirectAudioMute(0, state);
    }

    public void OnMenuControl(InputAction.CallbackContext context)
    {
        if (!context.started)
        {
            if (MenuControl.GamePaused)
            {
                m_vp.Pause();
            }
            else
            {
                m_vp.Play();
            }
        }
    }
}
