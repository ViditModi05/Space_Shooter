using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]  //Making sure that the player has the required component to avoid any errors
public class PlayerController : MonoBehaviour
{
    [Header("References")]
    private Rigidbody rb;
    [Header("Settings")]
    [SerializeField] private float moveSpeed;
    private float direction;
    void Start()
    {
      rb = GetComponent<Rigidbody>();  // Getting the component at the start
    }

    private void FixedUpdate()
    {
        direction = Input.GetAxisRaw("Horizontal"); //Returning the horizontal input recieved from the player
        rb.velocity = new Vector3(direction * moveSpeed,0,0); //moving the player in the x axis
    }
    void Update()
    {
        
    }
}
