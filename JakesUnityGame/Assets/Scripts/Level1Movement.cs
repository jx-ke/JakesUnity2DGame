using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Movement : MonoBehaviour
{
    public float jumpForce = 10;
    public float speed;


    private Rigidbody2D rb;
    private bool isJumping;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

        void Update()
    {

        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        } 
    }
    
        void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("foreground"))
        {
            isJumping = false;
        }

        if (other.gameObject.CompareTag("platform1"))
        {
            isJumping = false;
        }
    }  
}
