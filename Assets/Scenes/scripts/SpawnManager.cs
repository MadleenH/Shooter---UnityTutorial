﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // declares array of game objects for animal hording
    public GameObject [] Prefab; 
    private float spawnPosX = 20.0f;
    private float spawnPosZ = 32.0f;
    

    // Set variables for InvokeRepeating
    public float startDelay = 2.0f;
    public float repeatRate = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        // call custom method after StartDelay each time
       InvokeRepeating("SpawnRandomAnimal", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal(){
        int animalIndex = Random.Range(0,Prefab.Length);

            //funktioniert auch: int rangeX = Random.Range(-18,21);
            //random spwanposition:
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnPosX, spawnPosX),0, spawnPosZ);

            // clone animal prefac and spwan
            Instantiate(Prefab[animalIndex], spawnPosition, Prefab[animalIndex].transform.rotation);

            //funktioniert auch: Instantiate(Prefab[animalIndex], new Vector3(rangeX,0,35), Prefab[animalIndex].transform.rotation);
            //Instantiate(Prefab[animalIndex], new Vector3(0,0,35), Prefab[animalIndex].transform.rotation);
            Debug.Log("Spawned!");
    }
}