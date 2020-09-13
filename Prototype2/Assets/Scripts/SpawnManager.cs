using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Sam Ferstein
 * Assignment 3
 * This manages the spawning of the animals.
 */

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        StartCoroutine(SpawnRandomAnimalCoroutine());
        //InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    IEnumerator SpawnRandomAnimalCoroutine()
    {
        yield return new WaitForSeconds(3f);
        

        while(!healthSystem.gameOver)
        {
            SpawnRandomAnimal();
            
            yield return new WaitForSeconds(1.5f);
        }
    }
}
