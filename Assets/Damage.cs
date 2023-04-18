using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    // Variables for damage control
    [SerializeField] private int obstacleDamage;
    [SerializeField] private GameObject _gameManager;

    // Variables for teleportation and checkpoints
    //public GameObject Player;
    public GameObject ToCheckpoint0;
    public GameObject ToCheckpoint1;
    public GameObject ToCheckpoint2;
    public GameObject ToCheckpoint3;

    void Start()
    {
        // Heart is subtracted by 1 an obstacle is hit -> damage control
        obstacleDamage = 1;
        _gameManager = GameObject.Find("GameManager");
    }

    private void OnCollisionEnter (Collision target)
    {
        Debug.Log(target.gameObject.name.ToString());
        // If the game object's name starts with "Obstacle"...
        if (target.gameObject.name.ToString().StartsWith("Obstacle"))
        {
            Debug.Log("message");
            // ...then run DamageControl function
            DamageControl();

            // If the game object's name has the "Untagged" tag...
            if (target.gameObject.CompareTag("Untagged"))
            {
                // ...then trigger the sound effect dedicated to it...
                GetComponent<AudioSource>().Play();
                Debug.Log("collision!");
                // ...and run Teleport0 function
                Teleport0();
            }
        }

        // If the game object's name has the "ToCheckpoint1" tag...
        if (target.gameObject.CompareTag("ToCheckpoint1"))
        {
            // ...then trigger the sound effect dedicated to it...
            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            // ...and run Teleport1 function
            Teleport1();
        }

        // If the game object's name has the "ToCheckpoint2" tag...
        if (target.gameObject.CompareTag("ToCheckpoint2"))
        {
            // ...then trigger the sound effect dedicated to it...
            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            // ...and run Teleport2 function
            Teleport2();
        }

        // If the game object's name has the "ToCheckpoint3" tag...
        if (target.gameObject.CompareTag("ToCheckpoint3"))
        {
            // ...then trigger the sound effect dedicated to it...
            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            // ...and run Teleport3 function
            Teleport3();
        }
    }
    void DamageControl()
    {
        // Get the health integer (component) from the GameManagerScript script and...create the health system by losing a heart for each obstacle hit
        _gameManager.GetComponent<GameManagerScript>().health = _gameManager.GetComponent<GameManagerScript>().health - obstacleDamage;
        Debug.Log(_gameManager.GetComponent<GameManagerScript>().health);
        // Get the UpdateHealth function (component) to keep track of the history of hearts that have been lost
        _gameManager.GetComponent<GameManagerScript>().UpdateHealth();
        //gameObject.SetActive(false);
    }

    // To teleport, change the first controller's position to where the game object's checkpoint is
    void Teleport0()
    {
        transform.position = ToCheckpoint0.transform.position;
    }
    void Teleport1()
    {
        transform.position = ToCheckpoint1.transform.position;
    }
    void Teleport2()
    {
        transform.position = ToCheckpoint2.transform.position;
    }
    void Teleport3()
    {
        transform.position = ToCheckpoint3.transform.position;
    }
}
