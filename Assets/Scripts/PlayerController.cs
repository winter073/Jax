using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for Jax
//Written by Paul Iradi
public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 500.0f;
    public float trueJumpSpeed = 5.0f;
    private AudioSource playerAudio;
    public AudioClip backgroundMusic;
    public AudioClip jumpSound;
    public ParticleSystem explosionParticle;

    //Variables to ensure the player can't jump more that 1 time per face before touching the ground
    private bool posYjump = true;
    private bool negYjump = true;
    private bool posXjump = true;
    private bool negXjump = true;
    private bool posZjump = true;
    private bool negZjump = true;
    private bool trueJump = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Player");
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Goal: Get the player to be able to move in various ways
        //  Idea 1: 6 sides of a cube with 6 different colors. Player can press a button and "jump" in the direction of a face
        //          Player can only jump once per face before needing to touch the ground again to regain their jumps
        //          Universal jump button that makes the player move up no matter what orrientation they are in
        //          Camera is rotated using the mouse, and cube is controlled using QWE/ASD

        //If player presses a button, then a force will be applied to the opposite direction of the face so the cube moves
        if (Input.GetKeyDown(KeyCode.Q) && posXjump == true) //Press Q to move posX
        {
            playerRb.AddForce(transform.right * speed);
            posXjump = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.W) && posYjump == true) //Press W to move posY
        {
            playerRb.AddForce(transform.up * speed);
            posYjump = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.E) && posZjump == true) //Press E to move posZ
        {
            playerRb.AddForce(transform.forward * speed);
            posZjump = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.A) && negXjump == true) //Press A to move negX
        {
            playerRb.AddForce(-transform.right * speed);
            negXjump = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.S) && negYjump == true) //Press S to move negY
        {
            playerRb.AddForce(-transform.up * speed);
            negYjump = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.D) && negZjump == true) //Press D to move negZ
        {
            playerRb.AddForce(-transform.forward * speed);
            negZjump = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && trueJump == true) //Press Space to jump vertically no matter the player's orientation
        {
            playerRb.velocity = (playerRb.velocity + new Vector3(0, trueJumpSpeed));
            trueJump = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

        //If player holds a button, then the player will rotate either positively or negatively around the chosen axis
        if (Input.GetKey(KeyCode.R)) //Hold R to rotate positively around the Player's X arm 
        {
            transform.Rotate(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.F)) //Hold F to rotate negatively around the Player's X arm 
        {
            transform.Rotate(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.T)) //Hold T to rotate positively around the Player's Y arm
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.G)) //Hold G to rotate negatively around the Player's Y arm
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.Y)) //Hold Y to rotate positively around the Player's Z arm
        {
            transform.Rotate(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.H)) //Hold H to rotate negatively around the Player's Z arm
        {
            transform.Rotate(0, 0, 1);
        }

    }

    //Check to see if player collided with a ground object, if so then reset jumps to true
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            posYjump = true;
            negYjump = true;
            posXjump = true;
            negXjump = true;
            posZjump = true;
            negZjump = true;
            trueJump = true;
        }
    }

    //Check to see if player collided with pickup object, if so then destroy the pickup object and increment the counter by 1
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            explosionParticle.Play();
            Destroy(other.gameObject);
        }
    }

}
