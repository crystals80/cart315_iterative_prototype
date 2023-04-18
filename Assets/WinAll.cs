using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinAll : MonoBehaviour
{
    // Variable for reaching the finish platform and completing the game
    public GameObject Player;

    // On collision to an obstacle
    void OnCollisionEnter()
    {
        // ...trigger the sound effect dedicated to it...
        GetComponent<AudioSource>().Play();
        // ...and trigger the ending screen
        SceneManager.LoadScene("EndingScreen");
    }
}
