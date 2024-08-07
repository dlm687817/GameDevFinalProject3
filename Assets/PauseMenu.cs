using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;

    void Update()
    {

    }
    public void Instructions()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Instructions");
    }
    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainmenu");
    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
