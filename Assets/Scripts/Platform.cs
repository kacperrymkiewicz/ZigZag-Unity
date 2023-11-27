using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private GameManager gameManager;
    private StatisticsManager statisticsManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        statisticsManager = StatisticsManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RemovePlatform()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        Destroy(gameObject, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            statisticsManager.increaseScore(1);
            Debug.Log(statisticsManager.getScore());
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke("RemovePlatform", 0.2f);
        }
    }
}
