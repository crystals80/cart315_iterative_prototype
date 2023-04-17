using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variable for making the camera following the first controller
    public Transform player;

    void Update()
    {
        // Change the position of the camera as the first controller moves, at a certain distance
        transform.position = player.transform.position + new Vector3(5, 1, -5);
    }
}
