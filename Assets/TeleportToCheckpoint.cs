using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToCheckpoint : MonoBehaviour
{
    public GameObject Player;
    public GameObject ToCheckpoint1;
    public GameObject ToCheckpoint2;
    public GameObject ToCheckpoint3;

    /*public Transform player;
    public Vector3 point; //position of the point you want to rotate around

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.RotateAround(point, Vector3.left, 20 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
            player.transform.RotateAround(point, Vector3.right, 20 * Time.deltaTime);
    }*/

private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.CompareTag("ToCheckpoint1"))
        {
            
            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            Teleport1();
        }

        if (collision.gameObject.CompareTag("ToCheckpoint2"))
        {

            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            Teleport2();
        }

        if (collision.gameObject.CompareTag("ToCheckpoint3"))
        {

            GetComponent<AudioSource>().Play();
            Debug.Log("collision!");
            Teleport3();
        }
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
