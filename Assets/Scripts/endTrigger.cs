using UnityEngine;

public class endTrigger : MonoBehaviour
{   
    public GameManager gameManager;
   public void OnTriggerEnter2D(Collider2D collision)
    {
       gameManager.CompleteLevel();
    }
}
