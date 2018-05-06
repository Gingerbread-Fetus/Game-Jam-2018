using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TheManager : MonoBehaviour
{
    //Start time for one game
    public float time;
    //Player points
    private int playerOnePoints;
    private int playerTwoPoints;
    
    //Menu Canvas
    public Canvas menuCanvas;

    //Winner text message
    public Text winner;

    //Public bool to decide if game is still running
    [HideInInspector]
    public bool gameOver;
    public Scene scene;

    // Use this for initialization
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        gameOver = false;
        playerOnePoints = 0;
        playerTwoPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        //Deactivate cube colliders.
        gameOver = true;

        if (playerOnePoints > playerTwoPoints)
        {
            winner.text = "Player 1 wins!";
        }
        else if (playerTwoPoints > playerOnePoints)
        {
            winner.text = "Player 2 wins!";
        }
        else
        {
            winner.text = "You tied! You're both failures!";
        }

        
        menuCanvas.gameObject.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(scene.name);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }

    public int ReturnPoints(string player)
    {
        if (player == "1")
        {
            return playerOnePoints;
        }

        if (player == "2")
        {
            return playerTwoPoints;
        }
        return 0;
    }

    public void ScorePoint(string player)
    {
        if (player.Equals("Player1"))
        {
            playerOnePoints += 1;
            Debug.Log("Player 1 scored");
        }
        if (player.Equals("Player2"))
        {
            playerTwoPoints += 1;
            Debug.Log("Player 2 scored");
        }
    }
}
