using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Ball")
            return;
        
        // TODO :: HIT - END GAME - LOSE!
    }
}
