using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    Rigidbody2D player;
    Animator anim;
    bool jump;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            jump = true;
            if (jump)
               // anim.SetBool("jump", false);
                player.velocity = Vector2.up * 9;
                
                
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {

            if (jump)
                //anim.SetBool("jump", true);
                jump = false;
        }
    }
}
