using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Assignment 3
 * This spawns the balls.
 */

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;
    public HealthSystem healthSystem;
    private DisplayScore displayScore;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(3f, 5f);
        displayScore = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        StartCoroutine(SpawnRandomBallCoroutine());
    }

    private void Update()
    {
        if(displayScore.score >= 5)
        {
            healthSystem.gameOverText.SetActive(false);
            StopCoroutine(SpawnRandomBallCoroutine());
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int prefabIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[prefabIndex], spawnPos, ballPrefabs[prefabIndex].transform.rotation);
    }

    IEnumerator SpawnRandomBallCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while(!healthSystem.gameOver)
        {
            SpawnRandomBall();
            yield return new WaitForSeconds(5f);
        }
    }
}
