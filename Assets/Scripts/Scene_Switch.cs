using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Switch : MonoBehaviour
{
    // Switches to the next level/scene
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Skatepark_V1");
    }
}
