using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinFrog : MonoBehaviour
{
    public bool dirRight = true;
    Rigidbody2D enemy;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dirRight)
        {
            enemy.velocity = new Vector2( 5, enemy.position.y);
            sr.flipX = false;
        }
        if(!dirRight)
        {
            enemy.velocity = new Vector2(-5, enemy.position.y);
            sr.flipX = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
            dirRight = !dirRight;
        }
    }
}
