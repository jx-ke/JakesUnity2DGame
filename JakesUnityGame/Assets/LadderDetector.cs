using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderDetector : MonoBehaviour
{
    [SerializeField]
    private Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Ladder_01>())
        {
            player.ClimbingAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Ladder_02>())
        {
            player.ClimbingAllowed = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
