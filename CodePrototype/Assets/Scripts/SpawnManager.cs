using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    GameObject[] recipeSpawns;
    [SerializeField]
    GameObject recipePrefab; 
    void Start()
    {
        recipeSpawns = GameObject.FindGameObjectsWithTag("recipeSpawn");
    }

    void Update()
    {
        foreach(GameObject spawn in recipeSpawns)
        {
            GameObject spawnObj = Instantiate(recipePrefab, spawn.transform, false);
        }
    }
}
