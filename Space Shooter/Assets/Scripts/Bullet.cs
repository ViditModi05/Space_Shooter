using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform firePos;
    [SerializeField] private GameObject bullet;

    [Header("Settings")]
    [SerializeField] private float attackTimer;
    private bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canShoot)
        {
            Shoot();  //Calling the shoot function if the left MB is down and the player can shoot
        }
        
    }

    private void Shoot()
    {
        Instantiate(bullet, firePos.position, firePos.rotation); //Creating the bullet at the fire pos
        StartCoroutine(AttackDelay());
    }

    IEnumerator AttackDelay()  //Creatng a Coroutine to add delay between shots
    {
        canShoot = false;
        yield return new WaitForSeconds(attackTimer);
        canShoot = true;
    }
}
