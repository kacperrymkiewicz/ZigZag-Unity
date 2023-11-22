using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed;
    private bool rotated = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameStarted)
        {
            MoveCar();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RotateCar();
            }
        }

        if(transform.position.y < 0)
        {
            GameManager.instance.GameOver();
        }
    }

    void MoveCar()
    {
        transform.position += transform.forward * carSpeed * Time.deltaTime;
    }

    void RotateCar()
    {
        if(rotated)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            rotated = false;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rotated = true;
        }
    }
}
