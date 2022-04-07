using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    Rigidbody2D player;
   
    // Start is called before the first frame update
    void Start()
    {
        
        player = GetComponent<Rigidbody2D>();
       
      
    }

    // Update is called once per frame
    void Update()
    {
         player.velocity = new Vector2(2, player.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==8)
        {
            Destroy(gameObject);
        }
        
    }
}
