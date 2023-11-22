using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothValue;
    Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.y >= 0)
        {
            MoveCamera();   
        }
    }

    void MoveCamera()
    {
        Vector3 currentPosition = transform.position;
        Vector3 targetPosition = target.position - distance;

        transform.position = Vector3.Lerp(currentPosition, targetPosition, smoothValue * Time.deltaTime);
    }
}
