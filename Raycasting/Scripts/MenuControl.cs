using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuControl : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject m_pauseMenuUI;

    private void Start()
    {
        m_pauseMenuUI.SetActive(false);
    }

    public void OnMenuControl(InputAction.CallbackContext context)
    {
        if (!context.started)
        {
            if (GamePaused)
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
        GamePaused = false;
        Cursor.visible = false;
        Time.timeScale = 1f; // Reenable time-bound movements
        AudioListener.pause = false; // Unpause sound
        m_pauseMenuUI.SetActive(false);
    }

    private void PauseGame()
    {
        GamePaused = true;
        Cursor.visible = true;
        Time.timeScale = 0f; // Freeze time-bound movements
        AudioListener.pause = true; // Pause sound
        m_pauseMenuUI.SetActive(true);
    }
}
