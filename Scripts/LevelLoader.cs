using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1;

    }

    public void quitGame()
    {
        Application.Quit();
    }

    
}
