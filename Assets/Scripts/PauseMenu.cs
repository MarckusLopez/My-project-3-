using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;



public class PauseMenu : MonoBehaviour

{
    public static bool GameIsPaused = false;
    [SerializeField] GameObject pauseMenu;

    public void Pause()

    {

        pauseMenu.gameObject.SetActive(true);

        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()

    {

        pauseMenu.gameObject.SetActive(false);

        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Home(int SceneID)

    {

        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneID);

    }
   
        void update()
        {
            if (Input.GetKey(KeyCode.E))
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


