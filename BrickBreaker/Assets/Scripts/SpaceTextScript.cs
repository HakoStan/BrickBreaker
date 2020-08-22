using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceTextScript : MonoBehaviour
{
    private bool isActive = true;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Text>().enabled = false;
            isActive = false;
        }
        
        if(isActive)
        {
            timer = timer + Time.deltaTime;
            if(timer >= 0.5)
            {
                    GetComponent<Text>().enabled = true;
            }
            if(timer >= 1)
            {
                    GetComponent<Text>().enabled = false;
                    timer = 0;
            }
        }
    }
}
