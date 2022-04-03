using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public GameObject player;
    private GameObject focalPoint;

    private Vector3 CameraOffset = new Vector3(0, 10, 10);

    private Vector3 cameraAngle = new Vector3(40, 180, 0);

    void Start()
    {
        focalPoint = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {        
        // If the player clicks the mouse, the camera moves to the side a fixed distance
        
        if (Input.GetMouseButtonDown(0))
        {
            transform.RotateAround(focalPoint.transform.position, Vector3.up, 45);
        }
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0, -45, 0);
        }
        
        transform.position = player.transform.position + CameraOffset; // Move focal point with player
    }
}
