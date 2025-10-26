using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMovement : MonoBehaviour
{
  [SerializeField] private AudioClip jumpSoundClip;
  [SerializeField] private AudioClip deathSoundClip;
    public Rigidbody2D rb;
  public float playerSpeed;  //allows us to be able to change speed in Unity
public Vector2 jumpHeight;
BoxCollider2D boxColliderPlayer;
int layerMaskGround;
float heightTestPlayer;
GameManager gameManager;
    public PauseMenu pauseMenu;


    // Use this for initialization
    void Start () {
  rb = GetComponent<Rigidbody2D>();
  gameManager = FindObjectOfType<GameManager>();
    // Get the player's collider so we can calculate the height of the character.
    boxColliderPlayer = GetComponent<BoxCollider2D>();
    // We do the height test from the center of the player, so we should only check
    // halft the height of the player + some extra to ignore rounding off errors.
    heightTestPlayer = boxColliderPlayer.bounds.extents.y + 0.05f;
    // We are only interested to get colliders on the ground layer. If we would
    // like to jump ontop of enemies we should add their layer too (which then of
    // course can't be on the same layer as the player).
    layerMaskGround = LayerMask.GetMask("Ground");
}
    // Update is called once per frame
    void Update()
    {
        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);  //makes player run

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())  //makes player jump
        {
            rb.AddForce(jumpHeight, ForceMode2D.Impulse);
            SoundFXManager.instance.PlaySoundFXClip(jumpSoundClip, transform, 1f);
        }
        if (rb.position.y < -1f)
        {
            gameManager.EndGame();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
    
        }
    }

private bool IsGrounded()
{
    // Note that we only check for colliders on the Ground layer (we don't want to hit ourself). 
    RaycastHit2D hit = Physics2D.Raycast(boxColliderPlayer.bounds.center, Vector2.down, heightTestPlayer, layerMaskGround);
    bool isGrounded = hit.collider != null;
    // It is soo easy to make misstakes so do a lot of Debug.DrawRay calls when working with colliders...
    Debug.DrawRay(boxColliderPlayer.bounds.center, Vector2.down * heightTestPlayer, isGrounded ? Color.green : Color.red, 0.5f);
    return isGrounded;
}
 public void OnTriggerEnter2D(Collider2D collision)
 {
     if (collision.CompareTag("Obstacle")){
       SoundFXManager.instance.PlaySoundFXClip(deathSoundClip, transform, 1f);
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
     }
 
       
}
