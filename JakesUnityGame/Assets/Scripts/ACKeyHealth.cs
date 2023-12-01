using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACKeyHealth : MonoBehaviour
{
    public int currentHealth3;
    public int maxHealth3;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
            Debug.Log("HIT");
        }
    }
}
