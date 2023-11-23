using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticsManager
{
    private int currentScore = 0;
    private int bestScore = 0;

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
