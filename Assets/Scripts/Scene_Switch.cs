using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script for Jax
//Written by Kenny Huynh

public class Scene_Switch : MonoBehaviour
{
    private int sceneInt;

    // Switches to the next level/scene
    void OnTriggerEnter(Collider other)
    {
        changeScene();
        if (sceneInt > 1)
        {
            SceneManager.LoadScene("Skatepark_V1");
        }
        else
        {
            SceneManager.LoadScene("Tutorial_Camera");
        }
    }

    public void changeScene()
    {
        sceneInt++;
    }
}
