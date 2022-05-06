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
        focalPoint = GameObject.Find("Focal Point");
        focalPoint.transform.rotation = Quaternion.Euler(50, transform.rotation.eulerAngles.y, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //Attempt to lock Axis
        //transform.position.z=0

        if (focalPoint.transform.rotation.eulerAngles.z != 0)
        {
            //focalPoint.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);

        }

        // Allows the player to rotate the camera to the left and right while keeping the Jax in the center of the screen
        if (Input.GetAxis("Mouse X") < 0)
        {
            //Code for action on mouse moving left
            transform.Rotate(0, 1, 0);
            
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            //Code for action on mouse moving right
            transform.Rotate(0, -1, 0);
        }

        //Allows the player to move the camera up and down
        if (Input.GetAxis("Mouse Y") > 0 && focalPoint.transform.rotation.eulerAngles.x < 85)
        {
            //Mouse Up
            transform.Rotate(1, 0, 0);
            Debug.Log("LOOK UP");

        }
        if (Input.GetAxis("Mouse Y") < 0 && focalPoint.transform.rotation.eulerAngles.x > 10)
        {
            //Mouse Down
            transform.Rotate(-1, 0, 0);
            Debug.Log("LOOK DOWN");
        }
        //Debug.Log("X: " + focalPoint.transform.rotation.eulerAngles.x);

        focalPoint.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        transform.position = player.transform.position; // Move focal point with player
    }
}
