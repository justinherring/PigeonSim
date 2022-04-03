using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public Transform[] spawnLocations;

    void Start()
    {
        for (int i = 0; i < spawnLocations.Length; i++)
        {
            Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnLocations[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
