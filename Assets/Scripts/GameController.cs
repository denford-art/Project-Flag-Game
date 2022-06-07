using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Fader fader;
    [SerializeField] private PauseMenu pauseMenu;
    [SerializeField] private int restartLevel;

    void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        StartCoroutine(StartRoutine());
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(restartLevel);
    }

    public void PauseGame()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void ToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }

    public void LoseGame()
    {
        StartCoroutine(LoseRoutine());
    }

    private IEnumerator StartRoutine()
    {
        yield return StartCoroutine(fader.Fade(false));

        fader.gameObject.SetActive(false);

        Time.timeScale = 1;
    }

    private IEnumerator LoseRoutine()
    {
        Time.timeScale = 0.4f;

        fader.gameObject.SetActive(true);

        yield return StartCoroutine(fader.Fade(true));

        StartCoroutine(fader.StartBlinkRetryBtn());
    }
}