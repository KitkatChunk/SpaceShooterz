using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Abdulkarem Alani #300993768
/// This is a Game Controller Takes care of UI (Score and Hearts), Scoring (Update score and heart), and Scene managment (Game over scene is played when hearts reaches 0).
/// Assets were used from opengameart.
/// SpaceShip UFO : https://opengameart.org/content/enemy-game-character-ufo-spaceship
/// Track Sound : https://opengameart.org/content/space-walk
/// Background / Player : https://opengameart.org/content/dirt-platformer-tiles
/// </summary>

public class GameController : MonoBehaviour
{
    public GameController gameController;

    // UI headers for score and hearts private and serialized.
    [Header("Scoreboard")]
    [SerializeField]
    private int _hearts;

    [SerializeField]
    private int _score;

    public Text HeartsLabel;
    public Text ScoreLabel;
    // Setting hearts to the amount of hearts as an int, when the hearts reaches 0 GameOver scene is played.
    public int Hearts
    {
        get
            {
            return _hearts;
            }
        set
            {
            _hearts = value;
            if (_hearts <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                HeartsLabel.text = "Hearts: " + _hearts.ToString();
            }
          
   
        }



    }
    // Score counter and updater 
    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            ScoreLabel.text = "Score: " + _score.ToString();
        }



    }


    // Start is called before the first frame update
    void Start()
    {
        Hearts = 20;
        Score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
  
}
