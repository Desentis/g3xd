using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        //SceneManager.LoadScene("StartGame")
        Debug.Log("StartGame");
    }

    public void LoadGame()
    {
        //SceneManager.LoadScene("LoadGame")
        Debug.Log("LoadGame");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
