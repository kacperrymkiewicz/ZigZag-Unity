using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public StatisticsManager statistics;
    public GameObject platformGenerator;
    public bool gameStarted;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        statistics = new StatisticsManager();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameStart();
            }
        }   
    }

    public void GameStart()
    {
        gameStarted = true;
        platformGenerator.SetActive(true);
    }

    public void GameOver()
    {
        platformGenerator.SetActive(false);
        Invoke("RestartGame", 2f);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
