using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
        Invoke("Reload", 5f);
    }
    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}