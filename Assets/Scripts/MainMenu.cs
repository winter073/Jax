using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Tutorial_Move");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Level2()
    {
        SceneManager.LoadScene("Tutorial_Camera");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Skatepark_V1");
    }
}
