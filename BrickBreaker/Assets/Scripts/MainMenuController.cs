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

    public void AboutButtonOnClick()
    {
        // YA :: TODO ::
            // Show some other canvas maybe.
            // Maybe Disable / Enable some canvas
    }

    public void QuitGameButtonOnClick()
    {
        Application.Quit();
    }
}
