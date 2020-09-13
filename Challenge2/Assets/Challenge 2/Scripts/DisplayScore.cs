using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Sam Ferstein
 * Assignment 3
 * This manages the score and game win screen.
 */

public class DisplayScore : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameWonText;
    public static bool gameOver = false;
    public static bool gameWon = false;
    public int score = 0;
    public HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        gameWon = false;
        gameOver = false;
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!healthSystem.gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        if (score >= 5)
        {
            gameWon = true;
            gameOver = true;
        }
        if(gameOver)
        {
            if (gameWon)
            {
                gameWonText.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }
}
