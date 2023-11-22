using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public bool gameStarted;

    private void Awake()
    {
        if(instance == null) 
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    public void GameOver()
    {

    }
}
