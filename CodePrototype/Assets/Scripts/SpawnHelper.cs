using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHelper : MonoBehaviour
{
    GameObject[] ingredientSpawns;
    [SerializeField]
    GameObject ingredientPrefab;
    void Start()
    {
        ingredientSpawns = GameObject.FindGameObjectsWithTag("ingredientSpawn");
    }

    void Update()
    {
        foreach (GameObject spawn in ingredientSpawns)
        {
            GameObject spawnObj = Instantiate(ingredientPrefab, spawn.transform, false);
        }
    }
}
