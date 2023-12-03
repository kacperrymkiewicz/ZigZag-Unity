using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed;
    private bool rotated = false;
    private bool firstTap = true;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("rotated: " + rotated.ToString());
        //Debug.Log("first input: " + firstInput.ToString());
        if (gameManager.gameStarted && !PauseMenu.isPaused)
        {
            MoveCar();
            if (firstTap)
            {
                firstTap = false;
                return;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RotateCar();
            }
        }

        if(transform.position.y < 0)
        {
            gameManager.GameOver();
        }
    }

    void MoveCar()
    {
        transform.position += transform.forward * carSpeed * Time.deltaTime;
    }

    void RotateCar()
    {
        if(transform.position.y > 1)
        {
            if (rotated)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                rotated = false;
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                rotated = true;
            }
        }
    }
}
