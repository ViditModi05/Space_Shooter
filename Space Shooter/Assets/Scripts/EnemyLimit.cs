using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLimit : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
