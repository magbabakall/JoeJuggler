using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public PauseButton pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        pauseButton = GameObject.FindGameObjectWithTag("PauseButton").GetComponent<PauseButton>();
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseButton.isPaused == true)
        {
            pauseGame();
        }
        
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        pauseButton.isPaused = false;
       
;    }

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
       
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
