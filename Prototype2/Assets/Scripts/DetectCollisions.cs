using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Sam Ferstein
 * Assignment 3
 * This destroys objects when colliding with one another.
 */

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScore;

    private void Start()
    {
        displayScore = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    void OnTriggerEnter(Collider other)
    {
        displayScore.score++;
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
