using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "Player") // If we don't check this, an enemy touching a coin would make the player collect it...
            c.GetComponent<PlayerNS>().CollectCoins(); // Player is the Player.cs component of the player object.
    }

    void OnTriggerExit(Collider c)
    {
        // If it's the player who passed through the coin and collected it, then and ONLY then destroy the coin
        if (c.gameObject.name == "Player")
            Destroy(gameObject);
    }
}
