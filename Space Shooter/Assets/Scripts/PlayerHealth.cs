using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{   
    [Header("References")]
    [SerializeField] private HealthBar healthbar;
    [SerializeField] private GameObject gameOver;
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
   
   public void Restart()
   {   
      Time.timeScale = 1f;
      string currentScene = SceneManager.GetActiveScene().name;
      SceneManager.LoadScene(currentScene);
      //gameOver.SetActive(false);
   }

    public void Damage()
    {
        currentHealth--;
        DamageEffect.instance.ShowDamageEffect();   
        healthbar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            //Destroy(gameObject);
            gameOver.SetActive(true);
        }
    }
}
