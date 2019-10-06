using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abdulkarem Alani #300993768
/// This is a player controller responsible for getting user input to move the player at certain speed, moving the player in the direction the user wants to move it, 
/// and register collision with other objects and deducts heart accordingly or increase scoring points.
/// Assets were used from opengameart.
/// SpaceShip UFO : https://opengameart.org/content/enemy-game-character-ufo-spaceship
/// Track Sound : https://opengameart.org/content/space-walk
/// Background / Player : https://opengameart.org/content/dirt-platformer-tiles
/// </summary>

public class Player : MonoBehaviour
{
    public float speed;

    public GameController gameController;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    // Getting user input and controlling the player into direction x speed.
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

    }

    // Detecting collisions between the player and other objects and substracting the amount of hearts that each enemy/obsticle hurt the player.
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Spikes":
                gameController.Hearts -= 1;
                break;

            case "Lava":
                gameController.Score += 50;
                break;

            case "SpaceShipYellow":
                gameController.Hearts -= 1;
                break;

            case "SpaceShipOrange":
                gameController.Hearts -= 2;
                break;

            case "SpaceShipRed":
                gameController.Hearts -= 3;
                break;

            case "SpaceShipPurple":
                gameController.Hearts -= 10;
                break;
        }

    }
}
