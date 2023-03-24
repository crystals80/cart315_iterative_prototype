using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public GameObject Player;

    //void OnCollisionEnter(Collision collision)
    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
        Invoke("Reload", 2.5f);
    }

    void Reload(/*Collision collision*/)
    {
        SceneManager.LoadScene("WorkingScene");
        /*if (collision.gameObject.CompareTag("FinishOne"))
        {
            SceneManager.LoadScene("WorkingScene");
        }*/
    }

}