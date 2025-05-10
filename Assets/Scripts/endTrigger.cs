using UnityEngine;
using UnityEngine.SceneManagement;
public class endTrigger : MonoBehaviour
{   
     [SerializeField] private AudioClip endLevelSoundClip;
    public GameManager gameManager;
   public void OnTriggerEnter2D(Collider2D collision)
    {
       gameManager.CompleteLevel();
     SoundFXManager.instance.PlaySoundFXClip(endLevelSoundClip, transform, 1f);
    }
}
