using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{   
    [Header("References")]
    [SerializeField] private HealthBar healthbar;
    [Header("Settings")]
    [SerializeField] private int currentHealth; 
    [SerializeField] private int maxHealth;

    public static PlayerHealth instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.MaxHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    public void Damage()
    {
        currentHealth--;
        healthbar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
