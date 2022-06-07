using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    private void Start()
    {
    }

    public void MainMenu()
    {
        gameController.ToMainMenu();
    }

    public void Resume()
    {
        gameObject.SetActive(false);
        gameController.ResumeGame();
    }

    public void Restart()
    {
        gameObject.SetActive(false);
        gameController.Restart();
    }
}