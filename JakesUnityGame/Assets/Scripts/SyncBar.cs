using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncBar : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite[] spriteArray;
    // Start is called before the first frame update
    void Start()
    {
      spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

        void ChangeSprite()
        {
            spriteRenderer.sprite = spriteArray[0]; 
        }
   
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Score")
            {
                 ChangeSprite(newSprite);
            }
        }

    // Update is called once per frame   
}
