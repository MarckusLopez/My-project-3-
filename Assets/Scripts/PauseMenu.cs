using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;



public class PauseMenu : MonoBehaviour

{

    [SerializeField] GameObject pauseMenu;







    public void Pause()

    {

        pauseMenu.gameObject.SetActive(true);

        Time.timeScale = 0f;

    }



    public void Resume()

    {

        pauseMenu.gameObject.SetActive(false);

        Time.timeScale = 1f;

    }



    public void Home(int SceneID)

    {

        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneID);

    }

}