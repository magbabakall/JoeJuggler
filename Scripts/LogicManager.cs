using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;

    void Start()
    {
       
    }

    [ContextMenu("Increase Score")]
    public void addScore(int score)
    {
        playerScore = playerScore + score;
        scoreText.text = playerScore.ToString();
    }

    public void currentScore(int score)
    {
        score = playerScore;
    }
}
