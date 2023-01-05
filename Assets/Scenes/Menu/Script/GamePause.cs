using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    public static bool isPause = false;

    public GameObject escapeMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (isPause)
            {
                Resume();
            }
            else
            {
                Pause();
            } 
        }
    }
    public void Pause()
    {
        escapeMenu.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }

    public void Resume()
    {
        escapeMenu.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
