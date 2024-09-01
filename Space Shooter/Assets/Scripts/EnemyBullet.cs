using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyBullet : MonoBehaviour
{
    [Header("References")]
    private Rigidbody rb;
    
    [Header("Settings")]
    [SerializeField] private float bulletSpeed;

    private void Awake()
    {
        Destroy(gameObject,6F); 
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
        rb.velocity = transform.forward * bulletSpeed; //Moving the bullet forward at the start,i.e when it is created
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
