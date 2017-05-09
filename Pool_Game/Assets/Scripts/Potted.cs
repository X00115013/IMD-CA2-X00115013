using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

/*
 * IMD CA2 Pool Game
 * Thomas Murray
 * X00115013
 */

public class Potted : MonoBehaviour {

    public static bool ballOrder;
    public static bool white, playerOne, playerTwo;
    public static int playerOneScore, playerTwoScore;
    public GameObject score1;
    public GameObject score2;
    public GameObject winner;
    private string result;
    private GameObject cueBall;
    private bool potted;
    private bool ball1, ball2, ball3, ball4, ball5, ball6, ball7, ball8, ball9, ball10, ball11, ball12, ball13, ball14, ball15;
    private bool[] ballsLeft = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true, true, true }; 


    // Use this for initialization
    void Start () {
        white = true;
        playerOne = true;
        playerTwo = false;
        playerOneScore = 0;
        playerTwoScore = 0;
        potted = false;
    }

    void Update()
    {
        setCountTextp1();
        setCountTextp2();
        var cueBallmotion = cueBall.GetComponent<Rigidbody>();
        
        //Change player as soon as the cue ball stops
        if (cueBallmotion.velocity == Vector3.zero)
        {
            if (playerOne == true)
            {
                playerTwo = true;
                playerOne = false;
            }
            if (playerTwo == true)
            {
               playerOne = true;
               playerTwo = false;
            }
        }
    }

    //Getters / Setters
    public bool player1Get()
    {
        return playerOne;
    }

    public bool player2Get()
    {
        return playerTwo;
    }

    public void player1Set(bool stat)
    {
        playerOne = stat;
    }

    public void player2Set(bool stat)
    {
        playerTwo = stat;
    }

    public bool pottedGet()
    {
        return potted;
    }

    public void pottedSet(bool pot)
    {
        potted = pot;
    }


    //Balls potted
    void OnCollisionEnter(Collision col)
    {

        GameObject temp;
        Rigidbody rb;
        if (col.gameObject.name == "spotted1")
        {
            Debug.Log("player 1 "+playerOne);
            Debug.Log("player 2 " + playerTwo);
            Destroy(col.gameObject);
            ballsLeft[0] = false;
            
        }
        else if (col.gameObject.name == "spotted2")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[1] = false;
            
        }
        else if (col.gameObject.name == "spotted3")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[2] = false;

        }
        else if (col.gameObject.name == "spotted4")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[3] = false;

        }
        else if (col.gameObject.name == "spotted5")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[4] = false;

        }
        else if (col.gameObject.name == "spotted6")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[5] = false;

        }
        else if (col.gameObject.name == "spotted7")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[6] = false;

        }
        else if (col.gameObject.name == "stripped1")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[7] = false;

        }
        else if (col.gameObject.name == "stripped2")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[8] = false;


        }
        else if (col.gameObject.name == "stripped3")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[9] = false;

        }
        else if (col.gameObject.name == "stripped4")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[10] = false;

        }
        else if (col.gameObject.name == "stripped5")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[11] = false;

        }
        else if (col.gameObject.name == "stripped6")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[12] = false;

        }
        else if (col.gameObject.name == "stripped7")
        {
            changePlayer();
            potted = true;
            Destroy(col.gameObject);
            ballsLeft[13] = false;

        }
        else if (col.gameObject.name == "BlackBall")
        {
            for (int i = 0; i < 14; i++)
            {
                if (ballsLeft[i] == true)
                {
                    gameOverBlackBall();
                }
            }
            if (playerOne == true)
            {
                playerOneScore += 1;
            }
            if (playerTwo == true)
            {
                playerTwoScore += 1;
            }
            gameOverScore();
            Destroy(col.gameObject);
        }
        //cue ball potted
        else if (col.gameObject.name == "CueBall")
        {
            temp = GameObject.Find("CueBall");
            rb = temp.GetComponent<Rigidbody>();
            StartCoroutine(MyMethod());
            temp.transform.position = new Vector3(-40.16f, -0.6f, -21.65f);
            rb.velocity = Vector3.zero;
            if (playerOne == true)
            {
                playerOneScore -= 1;
                playerOne = false;
                playerTwo = true;
            }
            else if (playerTwo == true)
            {
                playerTwoScore -= 1;
                playerTwo = false;
                playerOne = true;
            }
        }
    }
    void setCountTextp1()
    {
        var score1st = score1.GetComponent<UnityEngine.UI.Text>();
        score1st.text = String.Format("Player 1 Score: {0}", playerOneScore);
    }

    void setCountTextp2()
    {
        var score2nd = score2.GetComponent<UnityEngine.UI.Text>();
        score2nd.text = String.Format("Player 2 Score: {0}", playerTwoScore);
    }

    //If black is potted before all balls are cleared
    public void gameOverBlackBall()
    {

        if (playerOne == false)
        {
            result = string.Format("The winner is Player 1");
        }
        if (playerTwo == false)
        {
            result = string.Format("The winner is Player 2");
        }

        var text = winner.GetComponentInChildren<UnityEngine.UI.Text>();
        text.text = result;
        winner.GetComponent<Canvas>().enabled = true;
    }

    //Finish game
    public void gameOverScore()
    {

        if (playerOneScore > playerTwoScore)
        {
            result = string.Format("The winner is Player 1");
        }
        else if (playerOneScore < playerTwoScore)
        {
            result = string.Format("The winner is Player 2");
        }
        else if (playerOneScore == playerTwoScore)
        {
            result = string.Format("It's a draw");
        }

        var win = winner.GetComponentInChildren<UnityEngine.UI.Text>();
        win.text = result;
        winner.GetComponent<Canvas>().enabled = true;
    }

    //Change player
    public void changePlayer()
    {
        if (playerOne == true)
        {
            playerOneScore += 1;
            playerOne = true;
            playerTwo = false;
        }
        if (playerTwo == true)
        {
            playerTwoScore += 1;
            playerTwo = true;
            playerOne = false;
        }
    }

    IEnumerator MyMethod()
    {
        Debug.Log("Before Waiting 5 seconds");
        yield return new WaitForSeconds(5);
        Debug.Log("After Waiting 5 Seconds");
        yield break;
    }
}
