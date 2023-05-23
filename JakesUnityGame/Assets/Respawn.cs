 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

 
 public class KillPoint : MonoBehaviour 
 {
     public int Respawn;
     void start()
     {

     }

     void update()
     {

     }

     void OnTriggerEnter2D(Collider2D other)
     {
         if(other.CompareTag("Player"))
         {
             SceneManager.LoadScene(Respawn);
         }
     }
 }
 
     