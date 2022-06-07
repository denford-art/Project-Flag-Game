using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] private int nextLevelIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            ChangeScene();
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(nextLevelIndex);
    }
}