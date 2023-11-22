using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform lastPlatform;
    Vector3 lastPlatformPosition;
    Vector3 newPlatformPosition;

    // Start is called before the first frame update
    void Start()
    {
        lastPlatformPosition = lastPlatform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnPlatform()
    {
        GeneratePosition();
        Instantiate(platformPrefab, newPlatformPosition, Quaternion.identity);
        lastPlatformPosition = newPlatformPosition;
    }

    void GeneratePosition()
    {
        newPlatformPosition = lastPlatformPosition;

        bool direction = (Random.Range(0, 2) == 0) ? false : true;

        if (direction)
        {
            newPlatformPosition.x += 2;
        }
        else
        {
            newPlatformPosition.z += 2;
        }
    }
}
