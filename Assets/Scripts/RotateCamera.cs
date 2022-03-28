using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 CameraOffset = new Vector3(0, 8, 8);
    private Vector3 cameraAngle = new Vector3(40, 180, 0);

    // Update is called once per frame
    void Update()
    {        
        // If the player clicks the mouse, the camera moves to the side a fixed distance
        /*if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 45, 0);
        }
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0, -45, 0);
        }
        */
        transform.position = player.transform.position + CameraOffset; // Move focal point with player
    }
}
