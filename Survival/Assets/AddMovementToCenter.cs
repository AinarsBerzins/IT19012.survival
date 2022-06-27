using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMovementToCenter : MonoBehaviour
{
    private float minSpinSpeed = 1f;
    private float maxSpinSpeed = 5f;
    public float minSpeed = 10f;
    public float maxSpeed = 20f;
    private float spinSpeed;
    private float speed;
    Vector3 center = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 myVector;
    Rigidbody m_Rigidbody;

    void Start()
    {
        spinSpeed = Random.Range(minSpinSpeed, maxSpinSpeed);
        speed = Random.Range(minSpeed, maxSpeed);
        myVector = center - transform.position;
        myVector.Normalize();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        m_Rigidbody.velocity = myVector * speed;
    }
}
