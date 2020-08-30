using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

    public void BackButtonOnClick()
    {
        SceneManager.LoadScene(0);
    }

}
