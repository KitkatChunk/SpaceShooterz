using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abdulkarem Alani #300993768
/// This is a background controller that moves and resets the background from right to left. 
/// Assets were used from opengameart.
/// SpaceShip UFO : https://opengameart.org/content/enemy-game-character-ufo-spaceship
/// Track Sound : https://opengameart.org/content/space-walk
/// Background / Player : https://opengameart.org/content/dirt-platformer-tiles
/// </summary>

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

    
    // This method resets the background to the resetPosition
    void Reset()
    {
        transform.position = new Vector2(resetPosition, 0f );

    }




}
