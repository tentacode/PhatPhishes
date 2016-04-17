﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public GameObject pauseMenu;

	void Start()
	{
        Resume();
	}

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

	void Update()
	{
        if (Input.GetButtonDown("MenuCancel") || Input.GetKeyDown("tab")) {
            if (pauseMenu.activeSelf) {
                Resume();
            } else {
                Pause();
            }
        }
	}
}
