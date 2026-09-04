using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject menu;

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
}
