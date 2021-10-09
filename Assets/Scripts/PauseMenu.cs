using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
   
    /// <summary>
    /// This is the pause menu code. It kind of works but i don't understand why it only pauses the game once and forgets that you can pause?
    /// </summary>
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }

       // sets time to 1 or 0 using true or false.
       void Resume() 
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            
            GameIsPaused = true;
        }

        void Pause ()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }



    }
}
