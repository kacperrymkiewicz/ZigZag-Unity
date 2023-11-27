using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatisticsManager : MonoBehaviour
{
    public static StatisticsManager instance;
    private int currentScore = 0;
    private int bestScore = 0;
    public TMP_Text currentScoreText;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public int getScore()
    {
        return currentScore;
    }

    public int getBestScore()
    {
        return bestScore;
    }

    public void increaseScore(int value)
    {
        currentScore += value;
        currentScoreText.text = currentScore.ToString();

        if (currentScore > bestScore)
        {
            bestScore = currentScore;
        }
    }

    public void resetScore()
    {
        currentScore = 0;
    }
}
