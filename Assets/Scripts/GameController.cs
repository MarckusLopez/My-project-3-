using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography;
using UnityEngine;

public class GameController : MonoBehaviour
{

 private void OnTriggerEnter2D(Collider2D collision)
 {
     if (collision.CompareTag("Obstacle")){

    Invoke("Restart", 2);
}
     }
     }
     
 

