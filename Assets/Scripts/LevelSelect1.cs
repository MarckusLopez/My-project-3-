using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect1 : MonoBehaviour
{
    public void one()
    {
        SceneManager.LoadScene(1);
    }
    public void two()
    {
        SceneManager.LoadScene(2);
    }
    public void three()
    {
        SceneManager.LoadScene(3);
    }
    public void four()
    {
        SceneManager.LoadScene(4);
    }
    public void five()
    {
        SceneManager.LoadScene(5);
    }
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
