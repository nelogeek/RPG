using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    public static bool isPause = false;

    public GameObject escapeMenus;
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
    void Pause()
    {
        escapeMenus.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }

    void Resume()
    {
        escapeMenus.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
        Cursor.visible = false;
    }

    void Exit()
    {
        Application.Quit();
    }
}
