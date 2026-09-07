using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    // public GameObject tapToStart;
    public GameObject scoreText;
    public GameObject mainMenuPanel;
    
    private void Start()
    {
        gameOverPanel.SetActive(false);
        // tapToStart.SetActive(true);
        scoreText.SetActive(true);
        PauseGame();
    }
    // private void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Mouse0))
    //     {
    //         StartGame();
    //     }
    // }
    public void GameOver()
    {
        // scoreText.SetActive(false);
        gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("FirstGame");
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("FirstGame");
        // mainMenuPanel.SetActive(true);
        // gameOverPanel.SetActive(false);
    }
    public void PauseGame()
    {
        Time.timeScale=0f;
    }
    public void StartGame()
    {
        scoreText.SetActive(true);
        // tapToStart.SetActive(false);
        Time.timeScale=1f;
    }
}
