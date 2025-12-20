using UnityEngine;
using TMPro;

public class EndTimer : MonoBehaviour
{
    public TextMeshProUGUI finalTimeText;

    void Start()
    {
        float finalTime = PlayerPrefs.GetFloat("SavedTime", 0f);

        int minutes = Mathf.FloorToInt(finalTime / 60);
        int seconds = Mathf.FloorToInt(finalTime % 60);

        finalTimeText.text = $"Final Time: {minutes:00}:{seconds:00}";
    }
}
