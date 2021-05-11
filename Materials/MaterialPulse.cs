using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPulse : MonoBehaviour
{
    [Header("Opacity Parameters")]
    public float m_maxOpacity;
    public float m_minOpacity;
    public float m_opacityStep;

    [Header("Renderer and Material References")]
    public MeshRenderer m_objectRenderer;
    public Material m_objectMaterial;

    private Color m_tempColor;

    // Start is called before the first frame update
    void Start()
    {
        m_objectRenderer = gameObject.GetComponent<MeshRenderer>();
        m_objectMaterial = m_objectRenderer.material;

        m_tempColor = new Color(m_objectMaterial.color.r, m_objectMaterial.color.g, m_objectMaterial.color.b, m_objectMaterial.color.a);
    }

    // Update is called once per frame
    void Update()
    {
        m_tempColor.a = Mathf.PingPong(Time.time * m_opacityStep, 1);
        m_objectMaterial.SetColor("_Color", m_tempColor);
    }
}
