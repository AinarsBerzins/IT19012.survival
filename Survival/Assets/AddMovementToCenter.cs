using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMovementToCenter : MonoBehaviour
{
    public float minSpinSpeed = 1f;
    public float maxSpinSpeed = 5f;
    public float minThrust = 0.1f;
    public float maxThrust = 1f;
    private float spinSpeed;
    Vector3 center = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 myVector;
    Rigidbody m_Rigidbody;
    float m_Speed = 10.0f;

    void Start()
    {
        spinSpeed = Random.Range(minSpinSpeed, maxSpinSpeed);
        myVector = center - transform.position;
        myVector.Normalize();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        m_Rigidbody.velocity = myVector * m_Speed;
    }
}
