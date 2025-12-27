using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] 
    public TextMeshProUGUI timerText;
    public float elapsedTime;
    bool isRunning = true;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if (!isRunning) return;
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void SaveTime()
    {
        PlayerPrefs.SetFloat("SavedTime", elapsedTime);
        PlayerPrefs.Save(); // forces write to disk
    }

    public void LoadTime()
    {
        elapsedTime = PlayerPrefs.GetFloat("SavedTime", 0f);
    }
    public void EndGame()
    {
        isRunning = false;
        PlayerPrefs.SetFloat("SavedTime", elapsedTime);
        PlayerPrefs.Save();
    }
  
}
