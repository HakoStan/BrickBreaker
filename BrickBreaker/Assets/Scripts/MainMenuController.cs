using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void StartButtonOnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGameButtonOnClick()
    {
        Application.Quit();
    }
}
