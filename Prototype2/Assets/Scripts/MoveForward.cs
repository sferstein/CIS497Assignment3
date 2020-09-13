using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Sam Ferstein
 * Assignment 3
 * This moves objects forwards.
 */

public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
