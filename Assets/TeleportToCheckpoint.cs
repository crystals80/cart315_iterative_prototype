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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ToCheckpoints"))
        {
            
            GetComponent<AudioSource>().Play();
            Invoke("Reload", 1f);
        }
    }

    void Teleport()
    {
        Player.transform.position = ToCheckpoint1.transform.position;
    }
}
