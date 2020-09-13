using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Assignment 3
 * This destroys the balls and dogs when they collide.
 */

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore displayScore;

    private void Start()
    {
        displayScore = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScore.score++;
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
