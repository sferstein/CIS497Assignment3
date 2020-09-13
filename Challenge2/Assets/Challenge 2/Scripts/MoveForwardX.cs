using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Assignment 3
 * This makes the dogs and balls go forward.
 */

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
