using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public GameObject completeLevelUI;
    public float restartDelay = 0f;
     public void CompleteLevel (){
completeLevelUI.SetActive(true);
 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
  
 
 public void Restart (){
 SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }
public void EndGame (){
if (player.position.y < -3 ){
    Invoke("Restart", restartDelay);
}

}

}
