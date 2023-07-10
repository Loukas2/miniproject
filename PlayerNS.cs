using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerNS : MonoBehaviour
{
    private int health = 10; // Initially private
    private int coins;

    public AudioSource audioSource;
    public AudioClip damageSound;
    
    void Start()
    {
        coins = 0; //This is also correct
    }

    void Update()
    {
        // Nothing here yet
    }

    public void CollectCoins() {
        coins++;
        print("Collected coins: " + coins);
    }

    public void TakeDamage(int damage) {
        
        health = health - damage;

        if (health > 0) {
            print("Player's health: " + health);
            audioSource.PlayOneShot(damageSound);
        }
        else {
            // Get the active scene index and use it to reload the scene
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}