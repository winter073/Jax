using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script for Jax
//Written by Kenny Huynh

public class Scene_Switch2 : MonoBehaviour
{
    // Switches to the next level/scene
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Skatepark_V1");
        }
    }
}
