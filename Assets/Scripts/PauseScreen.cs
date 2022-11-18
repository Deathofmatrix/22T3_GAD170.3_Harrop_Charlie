using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public static bool isPaused = false;
    [SerializeField] private GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            
            else
            {
                PauseGame();
            }
        }
    }

    private void ResumeGame()
    {
        Debug.Log("resume");
        pauseMenuUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void PauseGame()
    {
        Debug.Log("pause");
        pauseMenuUI.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
