using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MillRotateMono : MonoBehaviour
{

    public Transform m_whatToRotate;
    public float m_speedRotation;
    public Vector3 m_rotationAxis = Vector3.forward;


    public void Reset()
    {
        m_whatToRotate = transform;
    }
    

    public void Update()
    {
        m_whatToRotate.Rotate(m_rotationAxis, m_speedRotation * Time.deltaTime, Space.Self);
    }
}
