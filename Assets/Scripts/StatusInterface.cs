using UnityEngine;
using UnityEngine.UI;

public class StatusInterface : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    private void Start()
    {
    }

    public void Pause()
    {
        gameController.PauseGame();
    }
}