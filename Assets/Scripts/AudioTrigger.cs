using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private AudioSource objectAudio;
    public AudioClip soundToPlay;
    public AudioClip fallenAudio;
    public bool hasPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        objectAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasPlayed == false)
        {
            objectAudio.PlayOneShot(soundToPlay, 1.0f);
            hasPlayed = true;
        }
        if (collision.gameObject.CompareTag("Player") && hasPlayed == false && gameObject.name == "FallenDown" && GameObject.FindGameObjectsWithTag("Pickup").Length <= 2)
        {
            objectAudio.PlayOneShot(fallenAudio, 1.0f);
            hasPlayed = true;
        }
    }
}
