using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayCurrentLevel()
    {
        SceneManager.LoadScene(4);
        Destroy(GameObject.Find("Audio Source"));
    }

    public void PlaySecondLevel()
    {
        SceneManager.LoadScene(5);
        Destroy(GameObject.Find("Audio Source"));
    }

    public void PlayThirdLevel()
    {
        SceneManager.LoadScene(6);
        Destroy(GameObject.Find("Audio Source"));
    }

    public void OpenLevelsList()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("You are exit");
        Application.Quit();
    }
}
