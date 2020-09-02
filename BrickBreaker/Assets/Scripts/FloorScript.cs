using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            player.GetComponent<PlayerScript>().LoseHealth();
        }
    }
}
