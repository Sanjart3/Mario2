using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameScreen;

    private void Start()
    {
        gameScreen.SetActive(true);
        gameOverCanvas.SetActive(false); // Ensure Game Over screen is hidden at the start
    }

    public void TriggerGameOver()
    {
        gameOverCanvas.SetActive(true); // Show the Game Over screen
        gameScreen.SetActive(false);

        Time.timeScale = 0f; // Pause the game
    }

    public void TriggerRestart()
    {
        Time.timeScale = 1f; // Unpause the game

        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the scene
    }
}