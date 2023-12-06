using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseText;
    public static bool gameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!gameIsPaused)
            {
                pauseText.SetActive(true);
                Time.timeScale = 0f;
                gameIsPaused = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                pauseText.SetActive(false);
                Time.timeScale = 1f;
                gameIsPaused = false;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        
    }
}
