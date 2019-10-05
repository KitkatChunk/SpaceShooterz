using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
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
