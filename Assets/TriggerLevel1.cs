using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLevel1 : MonoBehaviour
{
    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
        Invoke("Reload", 1.59f);
    }
    void Reload()
    {
        SceneManager.LoadScene("Level1");
    }
}
