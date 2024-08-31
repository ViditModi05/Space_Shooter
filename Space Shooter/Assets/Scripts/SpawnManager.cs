using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject[] spawnPos;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject parent;

    [Header("Settings")]
    [SerializeField] private float spawnDelay;
    private bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn == true)
        {
           GameObject randomSpawnPoint = spawnPos[Random.Range(0, spawnPos.Length)];
            Instantiate(enemy, randomSpawnPoint.transform.position, Quaternion.identity, parent.transform);
           StartCoroutine(SpawnDelay());
        }
    }

    IEnumerator SpawnDelay()  //Creatng a Coroutine to add delay between spawns
    {
        canSpawn = false;
        yield return new WaitForSeconds(spawnDelay);
        canSpawn = true;
    }

}
