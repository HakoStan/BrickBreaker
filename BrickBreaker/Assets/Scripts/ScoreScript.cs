using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject player;

    void Start()
    {
        scoreText = GameObject.Find("ScoreNumber");
        player = GameObject.Find("Player");
    }

    void Update()
    {
        scoreText.GetComponent<UnityEngine.UI.Text>().text = player.GetComponent<PlayerScript>().score.ToString(); 
    }
}
