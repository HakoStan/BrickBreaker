using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public int score;
    void OnEnable()
    {
        GameObject.Find("ScoreNumber").GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("score").ToString();

        int won = PlayerPrefs.GetInt("won");
        if (won == 1)
        {
            GameObject.Find("WinOrLose").GetComponent<TMPro.TextMeshProUGUI>().text = "You Won!";
        }
    }

    public void BackButtonOnClick()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

}
