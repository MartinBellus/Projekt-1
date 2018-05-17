using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    bool pauseMenu = false;
    public GameObject pause;

    void Start() {
        pause = GameObject.FindGameObjectWithTag("Pause");
        pause.SetActive(false);
    }


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowPauseMenu();
        }
    }

    private void ShowPauseMenu()
    {
        if (pauseMenu)
        {
            pauseMenu = false;
            pause.SetActive(false);
            ContinueGame();
        } else
        {
            pauseMenu = true;
            pause.SetActive(true);
            PauseGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }
    private void ContinueGame()
    {
        Time.timeScale = 1;
    }
}
