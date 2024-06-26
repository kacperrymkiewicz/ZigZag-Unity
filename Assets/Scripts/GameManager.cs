using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    private StatisticsManager statisticsManager;
    private AudioManager audioManager;
    public GameObject platformGenerator;
    public GameObject beginPanel;
    public GameObject scorePanel;
    public bool gameStarted;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        statisticsManager = StatisticsManager.instance;
        audioManager = AudioManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.isPaused)
        {
            if (!gameStarted)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    GameStart();
                }
            }
        }
    }

    public void GameStart()
    {
        gameStarted = true;
        platformGenerator.SetActive(true);
        beginPanel.SetActive(false);
        scorePanel.SetActive(false);
        statisticsManager.currentScoreText.gameObject.SetActive(true);
        audioManager.playGameStartSound();
    }

    public void GameOver()
    {
        platformGenerator.SetActive(false);
        statisticsManager.currentScoreText.gameObject.SetActive(false);
        statisticsManager.saveScore();
        scorePanel.SetActive(true);
        audioManager.playGameOverSound();
        Invoke("RestartGame", 4f);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        beginPanel.SetActive(true);
    }
}
