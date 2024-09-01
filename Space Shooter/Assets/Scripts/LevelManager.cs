using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private GameObject completedScreen;
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy"); //Finding game objects with the player tag enemy and storing them in the array
        
    }
    void Update()
    {
        if(EnemiesDestroyed())
        {
            LevelCompleted(); //if all enemies are destroyed call the nextlevel function
        }
    }

    bool EnemiesDestroyed()
    {
        foreach(GameObject enemy in enemies)
        {
            if(enemy != null)
            {
                return false; //at least 1 enemy is still left
            }
        }

        return true; //all enemies are destroyed
    }
    
    private void LevelCompleted()
    {
       completedScreen.SetActive(true);
    }
    public void NextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex; //Getting the current active scene
        SceneManager.LoadScene(currentScene + 1); // loading the next level
  
    }
}
