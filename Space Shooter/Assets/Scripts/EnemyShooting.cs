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
    [SerializeField] private float attackTimer;
    private bool canShoot = true;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(canShoot == true)
        {
            SpawnBullet(); //Calling the SpawnBullet function if the player can shoot at fixed intervals
        }
    }

    private void SpawnBullet()
    {
        Instantiate(bullet, firePos.position, firePos.rotation); //Spawning the bullet
        StartCoroutine(AttackDelay());
    }

    IEnumerator AttackDelay()  //Creatng a Coroutine to add delay between shots
    {
        canShoot = false;
        yield return new WaitForSeconds(attackTimer); //Waiting for the attack timer to finish
        canShoot = true;
    }
}
