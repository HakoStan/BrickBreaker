using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public int score;
    public GameObject scoreNumber;
    public GameObject winOrLose;
    public GameObject highScoreNumber;

    void OnEnable()
    {
        int score = PlayerPrefs.GetInt("score");
        int highScore = PlayerPrefs.GetInt("highscore");
        scoreNumber.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        if (score > highScore)
        {
            PlayerPrefs.SetInt("highscore", score);
            highScore = score;
        }

        highScoreNumber.GetComponent<UnityEngine.UI.Text>().text = highScore.ToString();

        int won = PlayerPrefs.GetInt("won");
        if (won == 1)
        {
            winOrLose.GetComponent<TMPro.TextMeshProUGUI>().text = "You Won!";
        }
    }

    public void BackButtonOnClick()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

}
