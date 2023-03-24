using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float timeLeft = 15.0f;

    void Start()
    {
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            Debug.Log("timer done");
            SceneManager.LoadScene("WorkingScene");
        }
    }
}

