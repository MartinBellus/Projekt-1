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
            ContinueGame();
        } else
        {    
            PauseGame();
        }
    }

    private void PauseGame()
    {
        pauseMenu = true;
        pause.SetActive(true);
        Time.timeScale = 0;
    }
    public void ContinueGame()
    {
        pauseMenu = false;
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
