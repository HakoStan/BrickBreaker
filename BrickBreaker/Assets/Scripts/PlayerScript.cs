using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerScript : MonoBehaviour
{
    public RawImage[] hearts;
    public Texture fullHeart;
    public Texture emptyHeart;
    public int numberOfActiveBricks;
    public int score = 0;

    private int health;
    private int maxHealth;

    void Start()
    {
        health = hearts.Length;
        maxHealth = hearts.Length;
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].texture = fullHeart;
        }
    }

    void Update()
    {
        // Check Lose
        if (health <= 0)
        {
            FinishGame(false);
        }

        // Check Win
        if (numberOfActiveBricks <= 0)
        {
            FinishGame(true);
        }
    }

    public void GainHealth()
    {
        if (health < maxHealth)
        {
            hearts[health].texture = fullHeart;
            health++;
        }
    }

    public void LoseHealth()
    {
        hearts[health-1].texture = emptyHeart;
        health--;
    }

    private void FinishGame(bool isWin)
    {
        PlayerPrefs.SetInt("score", score);
        if (isWin)
        {
            PlayerPrefs.SetInt("won", 1);
        }
        else
        {
            PlayerPrefs.SetInt("won", 0);
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
