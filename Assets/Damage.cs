using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    // Variable for damage control
    [SerializeField] private int obstacleDamage;
    [SerializeField] private GameObject _gameManager;

    // Variables for Teleport and checkpoints
    public GameObject Player;
    public GameObject ToCheckpoint0;
    public GameObject ToCheckpoint1;
    public GameObject ToCheckpoint2;
    public GameObject ToCheckpoint3;

    void Start()
    {
        Debug.Log("hello");
        obstacleDamage = 1;
    }

    private void OnCollisionEnter (Collision target)
    {
        Debug.Log(target.gameObject.name.ToString());
        if (target.gameObject.name.ToString().StartsWith("Obstacle"))
        {
            Debug.Log("message");
            DamageControl();

            if (target.gameObject.CompareTag("Untagged"))
            {
                GetComponent<AudioSource>().Play();
                Debug.Log("collision!");
                Teleport0();
            }
        }

     
        if (target.gameObject.CompareTag("ToCheckpoint1"))
        {

            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            Teleport1();
        }

        if (target.gameObject.CompareTag("ToCheckpoint2"))
        {

            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            Teleport2();
        }

        if (target.gameObject.CompareTag("ToCheckpoint3"))
        {

            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            Teleport3();
        }
    }
    void DamageControl()
    {
        _gameManager.GetComponent<GameManagerScript>().health = _gameManager.GetComponent<GameManagerScript>().health - obstacleDamage;
        Debug.Log(_gameManager.GetComponent<GameManagerScript>().health);
        _gameManager.GetComponent<GameManagerScript>().UpdateHealth();
        //gameObject.SetActive(false);
    }

    void Teleport0()
    {
        Player.transform.position = ToCheckpoint0.transform.position;
    }
    void Teleport1()
    {
        Player.transform.position = ToCheckpoint1.transform.position;
    }
    void Teleport2()
    {
        Player.transform.position = ToCheckpoint2.transform.position;
    }
    void Teleport3()
    {
        Player.transform.position = ToCheckpoint3.transform.position;
    }
}
