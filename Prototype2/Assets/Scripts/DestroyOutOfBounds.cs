using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Sam Ferstein
 * Assignment 3
 * This destroys objects when out of bounds.
 */

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20;
    private float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }
    }
}
