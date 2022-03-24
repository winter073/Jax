using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for Jax
//Written by Paul Iradi
public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 50.0f;


    // Start is called before the first frame update
    void Start()
    {
       playerRb = GetComponent<Rigidbody>();
       focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float jumpInput = Input.GetAxis("Jump");

        playerRb.AddForce(transform.forward * verticalInput * speed * Time.deltaTime);

        //playerRb.AddForce(playerRb.transform.right * speed * horizontalInput);
        //playerRb.AddForce(playerRb.transform.forward * speed * verticalInput);
        //playerRb.AddForce(playerRb.transform.up * speed * jumpInput);

        //transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //transform.Rotate(Vector3.right, turnSpeed * verticalInput * Time.deltaTime);
        //transform.Rotate(Vector3.left, turnSpeed * jumpInput * Time.deltaTime);

    }
}
