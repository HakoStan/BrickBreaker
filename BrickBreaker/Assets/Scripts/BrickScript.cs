using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int hitCounter = 1;

    public void RecieveHitCount(int hitCounter)
    {
        this.hitCounter = hitCounter;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Ball")
            return;
        
        hitCounter--;
        if (hitCounter == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
