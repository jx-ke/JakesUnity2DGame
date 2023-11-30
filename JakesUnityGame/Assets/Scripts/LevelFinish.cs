 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

 
 public class LevelFinish : MonoBehaviour 
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
             SceneManager.LoadScene("Level2 StartScreen");
         }
     }
 }
