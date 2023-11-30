using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EndCollisionDONTDELETE : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (scoreManager != null)
        {
            
            Debug.Log(scoreManager);
            if (scoreManager.score == 3 && collision.gameObject.tag == "End") //two conditions need to be met: score = 3 and collision with object with "End" tag
            {
                
                SceneManager.LoadScene(4); // loads the End screen
                
            }
        }
    }

   
    
}