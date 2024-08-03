using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBullet : MonoBehaviour
{
    [Header("References")]
    private Rigidbody rb; 
    [Header("Settings")]
    [SerializeField] private float bulletSpeed;
    
    private void Awake()
    {
        Destroy(gameObject,2F); 
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        //Destroying the enemny if on collision the enemy haas the tag "Enemy" also destroying the bullet
    }
}
