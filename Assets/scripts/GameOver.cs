using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    Rigidbody2D player;
    public AudioSource sound;
    public Button but1;
    // Start is called before the first frame update
    void Start()
    {
        
        player = GetComponent<Rigidbody2D>();
        but1.Select();

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

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            sound.Play();
        }
    }
}
