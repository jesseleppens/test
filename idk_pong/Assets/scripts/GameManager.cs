using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    GameObject theBall;
    public Text playerOneScore;
    public Text playerTwoScore;


    public static void Score(string wallID)
    {
        if (wallID == "RightWall")
        {
            PlayerScore1++;
            
        }
        else
        {
            PlayerScore2++;

        }

    }

    void fortnite()
    {
        playerOneScore.text = PlayerScore1.ToString();
        playerTwoScore.text = PlayerScore2.ToString();
    }


    // Start is called before the first frame update
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
        playerOneScore = GameObject.Find("GameOverlay/PlayerOneScore").GetComponent<Text>();
        playerTwoScore = GameObject.Find("GameOverlay/PlayerTwoScore").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

