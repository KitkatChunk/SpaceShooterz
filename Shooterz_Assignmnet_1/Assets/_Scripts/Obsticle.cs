using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public float horizontalSpeed = 0.05f;
    public float resetPosition = 5f;
    public float resetPoint = -5f;
  

    // Update is called once per frame
    void Update()
    {
        Move();
        if (transform.position.x <= resetPoint)
        {
            Reset();
        }
    }

    
    // Moving the background using certain horizontal speed (from left to right)
   
    void Move()
    {
        Vector2 newPosition = new Vector2(horizontalSpeed, 0.0f);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

   // This method resets the background to start position
    void Reset()
    {
        float randomYPosition = Random.RandomRange(1.2f, -1.2f);
        transform.position = new Vector2(resetPosition, randomYPosition);
    }
}

