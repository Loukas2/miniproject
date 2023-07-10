using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public bool isActive; // Bonus

    public int minutes; // You put values in the editor
    public float seconds;

    // Update is called roughly every 0.01 seconds
    void Update()
    {
        if (isActive)
        {
            seconds -= Time.deltaTime;
            if (seconds <= 0.0f)
            {
                if (minutes > 0)
                {
                    seconds += 60.0f;
                    minutes--;
                }
                else {
                    // No time left, change scene
                    int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                    SceneManager.LoadScene(sceneIndex);

                    // And disable the timer
                    isActive = false;
                }
            }
        }
    }


}
