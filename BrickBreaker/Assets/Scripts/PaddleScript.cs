using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float m_speed;
    public float m_yPosition;

    private Rigidbody m_rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // YA :: TODO :: Add Force usage

        float xAxis = Input.GetAxis("Horizontal") * m_speed * Time.deltaTime;
        float zAxis = Input.GetAxis("Vertical") * m_speed * Time.deltaTime;
        transform.Translate(xAxis, 0 ,zAxis);
        
        // Locking y position of the object
        if (transform.position.y != m_yPosition) 
        {
            transform.position = new Vector3(transform.position.x, m_yPosition, transform.position.z);
        }
    }
}
