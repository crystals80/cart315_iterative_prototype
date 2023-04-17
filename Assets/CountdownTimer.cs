using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    // Variables for countdown timer
    public float timeLeft = 0;
    public bool timerIsRunning = false;

    public TextMeshProUGUI timeText;
    private void Start()
    {
        // Start the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        // If time is running...then time is running down to 0
        if (timerIsRunning)
        {
            // If the set time is not 0...
            if (timeLeft > 0)
            {
                // ...substract it according to the minutes and seconds of how time works (to be honest, I don't know how to describe this better than that...)
                timeLeft -= Time.deltaTime;
                // Display the set time on the level screen
                DisplayTime(timeLeft);
            }
            // If time is equal to 0...
            else
            {
                // ...trigger the sound effect dedicated to it...
                GetComponent<AudioSource>().Play();
                Debug.Log("Time has run out!");
                timeLeft = 0;
                // ...make time stop running...
                timerIsRunning = false;
                // ...and run the Reload function after a delay of 1 frame
                Invoke("Reload", 1f);
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        // Display time using minutes and seconds of the clock
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        // Display time via the text set in Unity by formatting it in minutes:seconds
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void Reload()
    {
        // Restart level by reloading the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

