using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Abdulkarem Alani #300993768
/// This moves the enemy Spaceship UFO from right to left and resets them .
/// Assets were used from opengameart.
/// SpaceShip UFO : https://opengameart.org/content/enemy-game-character-ufo-spaceship
/// Track Sound : https://opengameart.org/content/space-walk
/// Background / Player : https://opengameart.org/content/dirt-platformer-tiles
/// </summary>

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

    
    // Moving the Spaceship using certain horizontal speed (from left to right)
   
    void Move()
    {
        Vector2 newPosition = new Vector2(horizontalSpeed, 0.0f);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

   // This method resets the Spaceship to start position.
    void Reset()
    {
        float randomYPosition = Random.RandomRange(1.2f, -1.2f);
        transform.position = new Vector2(resetPosition, randomYPosition);
    }
}

