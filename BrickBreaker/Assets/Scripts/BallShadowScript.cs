using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShadowScript : MonoBehaviour
{
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ball.transform.position.x, 0.6f, ball.transform.position.z);
    }
}
