using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    
    Rigidbody2D player;
    
    Animator anim;
    float speed = 4, jumpForce = 10;
    public int nPulo = 2;
    bool mov=true;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Move();
    }

    

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && nPulo > 0)
            Jump();
    }

    void Move()
    {

        if (mov)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * speed;
        }
            
        
        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);

        }

        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("run", false);
        }

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nPulo--;
            player.velocity = Vector2.up * jumpForce;
            anim.SetBool("jump", true);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            nPulo = 2;
            anim.SetBool("jump", false);
        }

        if (collision.gameObject.layer == 9)
        {
            mov = false;
            anim.SetBool("dead", true);
            Invoke("GameOver", 1f);
            Destroy(gameObject, 1f);
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            anim.SetBool("run", false);
        }
    }

    void GameOver()
    {
        GameController.instance.ShowGameOver();
    }
}

