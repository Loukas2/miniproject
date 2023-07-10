using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    public float speed = 1.5f;
    public Transform target;
    public int playerDamage = 2;

    // On every frame
    void Update()
    {
        // Change the enemy's position
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
        // Change where the enemy is facing
        transform.LookAt(target.position);
    }

    void OnTriggerEnter(Collider other) {
        // If we didn't check and the enemy collides with the trap then we get an error
        // We would get an error because the trap does not have a "PlayerNS" script on it

        if (other.gameObject.name == "Player")
            other.GetComponent<PlayerNS>().TakeDamage(playerDamage);
    }
}
