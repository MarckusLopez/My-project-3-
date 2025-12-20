using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;



public class PauseMenu : MonoBehaviour

{
    public static bool GameIsPaused = false;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject TimerText;
    [SerializeField] GameObject pause;
    public NewMovement player;
    public void Pause()
    {
        TimerText.gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(true);
        pause.gameObject.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        player.canJump = false;   
    }

    public void Resume()

    {

        pauseMenu.gameObject.SetActive(false);

        Time.timeScale = 1f;
        GameIsPaused = false;
        TimerText.gameObject.SetActive(true);
        pause.gameObject.SetActive(true);
        player.canJump = true;
    }

    public void Home(int SceneID)

    {

        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneID);

    }
   
        void Update()
        {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
             if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
           
}
}


