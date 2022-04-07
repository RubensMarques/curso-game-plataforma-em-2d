using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    
    Rigidbody2D player;
    
    CapsuleCollider2D caps;
    
    
    Animator anim;
    
    public float speed, jumpForce;
    public int nPulo = 2;
    public bool mov=true;




    // Start is called before the first frame update
    void Start()
    {
       
        
            player = GetComponent<Rigidbody2D>();
            caps = GetComponent<CapsuleCollider2D>();
            anim = GetComponent<Animator>();
            
            GameController.gc.score = 0;
        
        //gcPlayer.gameOver.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {

        CheckInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && nPulo > 0)
            Jump();
    }

    void Move()
    {
        float movement = Input.GetAxis("Horizontal");


        if (mov)
        {
            
            player.velocity = new Vector2(movement * speed, player.velocity.y);
        }
         
        if (movement > 0f && mov)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (movement < 0f && mov)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);

        }

        if (movement == 0f && mov)
        {
            anim.SetBool("run", false);
        }

    }

    void Jump() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && mov)
        {
            nPulo--;
            player.velocity = Vector2.up * jumpForce;
            anim.SetBool("jump", true);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            player.velocity = Vector2.up * jumpForce;
            anim.SetBool("jump", false);
        }


        if (collision.gameObject.layer == 8)
        {
            nPulo = 2;
            anim.SetBool("jump", false);
        }

       if(collision.gameObject.layer == 9)
        {
            SceneManager.LoadScene("gameOver");
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            anim.SetBool("run", false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 12)
        {
            nPulo = 0;
        }

    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.CompareTag("apple"))
        {

            GameController.gc.uptadeScore();
                //GameController.gc.RefreshScreen();
          
        }
    }
   

    
}

