using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Fall apple;
    public GameObject gameOverMenu;

    void Start()
    {
        apple = GameObject.FindGameObjectWithTag("Fruit").GetComponent<Fall>();
        gameOverMenu.SetActive(false);
    }

    void Update()
    {
        gameOver();
    }

    public void gameOver()
    {
        if(apple.fallSpeed == 0)
        {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("GameOver");
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
