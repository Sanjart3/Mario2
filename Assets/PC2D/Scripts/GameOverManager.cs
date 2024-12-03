using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameScreen;

    private void Start()
    {
        gameScreen.SetActive(true);
        // Ensure Game Over screen is hidden at the start
        gameOverCanvas.SetActive(false);
    }

    public void TriggerGameOver()
    {
        // Show the Game Over screen
        gameOverCanvas.SetActive(true);
        gameScreen.SetActive(false);

        // Pause the game (optional)
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        // Unpause the game
        Time.timeScale = 1f;

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
