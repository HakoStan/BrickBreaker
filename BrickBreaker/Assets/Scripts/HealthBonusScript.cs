using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonusScript : MonoBehaviour
{
    public float speed;
    public GameObject brick;
    private GameObject ball;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        ball = GameObject.Find("Ball");
        Physics.IgnoreCollision(ball.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(brick.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(0f, -1f * speed, 0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Paddle")
        {
            player.GetComponent<PlayerScript>().GainHealth();
        }
        gameObject.SetActive(false);
    }
}
