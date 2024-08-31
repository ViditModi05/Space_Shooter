using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class EnemyShooting : MonoBehaviour
{
    [Header("References")] 
    [SerializeField] private Transform firePos;
    [SerializeField] private GameObject bullet;
    private Rigidbody rb;

    [Header("Settings")]
    //[SerializeField] private float attackTimer;
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;
    //private bool canShoot = true;


    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void SpawnBullet()
    {
        Instantiate(bullet, firePos.position, firePos.rotation); //Spawning the bullet
        
    }

    IEnumerator Shoot()  //Creatng a Coroutine to add delay between shots
    {
        while(true)
        {
           yield return new WaitForSeconds(Random.Range(minTime, maxTime)); //Waiting a random amount of time
           SpawnBullet(); //Calling the SpawnBullet function at random intervals
        } 
        
    }
}
