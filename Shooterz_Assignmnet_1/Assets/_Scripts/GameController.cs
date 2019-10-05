using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
