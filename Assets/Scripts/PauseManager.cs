using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject mainMenuPanel;

    public void PauseGame()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        menu.SetActive(false);
        SceneManager.LoadScene("FirstGame");
        // mainMenuPanel.SetActive(true);
        // Time.timeScale = 0f;
    }
}
