using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitTutorial : MonoBehaviour
{
    public void exitTutorial()
    {
        SceneManager.LoadScene(0);
    }
}
