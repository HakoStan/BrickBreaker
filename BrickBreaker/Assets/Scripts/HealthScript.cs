using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public int health;
    public int numberOfHearts;

    public RawImage[] hearts;
    public Texture fullHeart;
    public Texture emptyHeart;

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (health <= 0)
            {
                // DO: call game over function after implementation
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
}
