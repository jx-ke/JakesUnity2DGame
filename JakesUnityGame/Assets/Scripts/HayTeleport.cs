using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HayTeleport : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            
            if (collision.gameObject.tag == "Secret") //two conditions need to be met: score = 3 and collision with object with "End" tag
            {
                
                SceneManager.LoadScene(7); // loads the End screen
                
            }
        }
    }

   
    
}