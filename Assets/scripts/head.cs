using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head : MonoBehaviour
{
    public float movTime, timer, speed;

    public bool dirRight = true;

    SpriteRenderer sr;
    Rigidbody2D enemy;


    Animator anim;

    //public Transform headP;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dirRight)
        {

            enemy.position += new Vector2(Time.deltaTime * speed, enemy.velocity.y);
            sr.flipX = false;



        }
        if (!dirRight)
        {
            enemy.position += new Vector2(-Time.deltaTime * speed, enemy.velocity.y);
            sr.flipX = true;
        }

        timer += Time.deltaTime;

        if (timer >= movTime)
        {
            dirRight = !dirRight;
            timer = 0f;
        }
    }

    bool pd;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && !pd)
        {
            
                collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * 5;
                anim.SetTrigger("die");
                Destroy(gameObject, 1f);
               //anim.SetBool("idle", true);
            
        }
    }
}
