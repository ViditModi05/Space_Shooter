using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyController : MonoBehaviour
{
    [Header("Refernces")]
    //[SerializeField] private GameObject enemy;
    private Rigidbody rb;

    [Header("Settings")]
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1 ); // Moving the enemy on contact
            moveSpeed *= -1;
        }
    }






    
    // Discarded Movement

    // private void FixedUpdate()
    // {
    //     if(enemy == null)
    //     {
    //         return;
    //     }

    //     Vector3 forward = new Vector3(0, 0, -1);  //Getting the enemy to move forawrd
    //     forward = forward.normalized * moveSpeed * Time.deltaTime; //normalizing the forward vector
    //     rb.MovePosition(transform.position + forward);     //Moving the enemy
    // }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.tag == "Player")
    //     {
    //         Destroy(other.gameObject);
    //         Destroy(gameObject);
    //     }

    //     if(other.gameObject.tag == "Border")
    //     {
    //         Destroy(gameObject);
    //     }

    //     //Destroying the enemny if on collision the enemy has the tag "Player" also destroying the enemy
    // }
}
