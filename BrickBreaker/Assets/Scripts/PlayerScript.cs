using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerScript : MonoBehaviour
{
    public int health;
    public int numberOfHearts;

    public RawImage[] hearts;
    public Texture fullHeart;
    public Texture emptyHeart;

    public int score = 0;

    public int won = 1; // 0 means lose, 1 means win

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (health <= 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }

            if (health > numberOfHearts)
            {
                health = numberOfHearts;
            }

            if (i < health)
            {
                hearts[i].texture = fullHeart;
            }
            else
            {
                hearts[i].texture = emptyHeart;
            }
            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("score", score);
        foreach (var obj in FindObjectsOfType(typeof(GameObject)) as GameObject[]) // TODO: must be a better way finding out if all bricks are gone
        {
            if (obj.name == "Brick(Clone)" && obj.active == true)  
            {
                won = 0;
            }
        }
        PlayerPrefs.SetInt("won", won);
    }
}
