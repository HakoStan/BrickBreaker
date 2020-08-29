using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject m_paddle;
    //public float m_firstBouncePower;
    public float m_speed;

    private bool m_isBallMoving;

    // Start is called before the first frame update
    void Start()
    {
        m_isBallMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_isBallMoving = true;
            FirstBounce();
        }

        if(!m_isBallMoving)
        {
            transform.position = new Vector3(m_paddle.transform.position.x, m_paddle.transform.position.y + 1f, m_paddle.transform.position.z);
        }
        else
        {
            
        }
    }

    // First Time Setuo of Bounce
    void FirstBounce()
    {
        Debug.Log("BOUNCE");

        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;
        float sz = Random.Range(0, 2) == 0 ? -1 : 1;

        Rigidbody rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(m_speed * sx, m_speed * 1, m_speed * sy);

        //rb.AddForce(Vector3.up * m_firstBouncePower);
    }
}
