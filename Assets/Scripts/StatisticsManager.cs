using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatisticsManager : MonoBehaviour
{
    public static StatisticsManager instance;
    private AudioManager audioManager;
    private int currentScore = 0;
    public TMP_Text currentScoreText;
    public TMP_Text resultScoreText;
    public TMP_Text resultBestScoreText;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        audioManager = AudioManager.instance;
    }

    public int getScore()
    {
        return currentScore;
    }

    public int getBestScore()
    {
        return PlayerPrefs.GetInt("bestScore");
    }

    public void increaseScore(int value)
    {
        currentScore += value;
        currentScoreText.text = currentScore.ToString();
        if (currentScore % 10 == 0)
        {
            audioManager.playGameMilestoneSound();
        }

        if(PlayerPrefs.HasKey("bestScore"))
        {
            if (currentScore > PlayerPrefs.GetInt("bestScore"))
            {
                PlayerPrefs.SetInt("bestScore", currentScore);
            }
        }
        else
        {
            PlayerPrefs.SetInt("bestScore", currentScore);
        }
    }

    public void saveScore()
    {
        resultScoreText.text = "Wynik: " + getScore();
        resultBestScoreText.text = "Najlepszy wynik: " + getBestScore();
    }

    public void resetScore()
    {
        currentScore = 0;
    }
}
