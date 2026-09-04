using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject levelsPanel;
    public GameObject modesPanel;

    void Start()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        mainMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OpenLevels()
    {
        mainMenuPanel.SetActive(false);
        levelsPanel.SetActive(true);
    }

    public void OpenModes()
    {
        mainMenuPanel.SetActive(false);
        modesPanel.SetActive(true);
    }

    public void BackToMainMenuFromLevels()
    {
        levelsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void BackToMainMenuFromModes()
    {
        modesPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void SelectLevel1()
    {
        levelsPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SelectLevel2()
    {
        levelsPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SelectLevel3()
    {
        levelsPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void EasyMode()
    {
        modesPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MediumMode()
    {
        modesPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void HardMode()
    {
        modesPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}