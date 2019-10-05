using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed = 0.5f;
    public float resetPosition = 4.8f;
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

    // Moving the background to the left, using horizontal speed
    void Move()
    {
        Vector2 newPosition = new Vector2(horizontalSpeed, 0f);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

    /// <summary>
    /// This method resets the ocean to the resetPosition
    /// </summary>
    void Reset()
    {
        transform.position = new Vector2(resetPosition, 0f );

    }




}
