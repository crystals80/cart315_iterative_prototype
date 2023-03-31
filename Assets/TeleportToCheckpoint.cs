using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToCheckpoint : MonoBehaviour
{
    public GameObject Player;
    public GameObject ToCheckpoint1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.CompareTag("ToCheckpoints"))
        {
            
            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            Teleport();
        }
    }

    void Teleport()
    {
        Player.transform.position = ToCheckpoint1.transform.position;
    }
}
