using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentHealth--;
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
