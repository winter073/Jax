using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for Jax
//Written by Paul Iradi
public class RotateCamera : MonoBehaviour
{
    public GameObject player;
    private GameObject focalPoint;

    private Vector3 cameraAngle = new Vector3(40, 180, 0);

    void Start()
    {
        focalPoint = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {        
        // Allows the player to rotate the camera to the left and right while keeping the Jax in the center of the screen
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 45, 0);
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, -45, 0);
        }

        //Allows the player to move the camera up and down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(-15, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(15, 0, 0);
        }

        transform.position = player.transform.position; // Move focal point with player
    }
}
