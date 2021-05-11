using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator2 : MonoBehaviour
{
    public Vector3 m_startPos;
    public Vector3 m_endPos;
    public float m_velocity;

    void FixedUpdate()
    {
        float pos = Mathf.PingPong(Time.time * Time.deltaTime * m_velocity, 1);
        transform.position = Vector3.Lerp(m_startPos, m_endPos, pos);
    }
}
