using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    
    Rigidbody2D player;
    Animator anim;
    float speed = 4, jumpForce = 10;
    int nPulo = 2;
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
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
        
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
            player.velocity = Vector2.up * jumpForce;
            nPulo--;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            nPulo = 2;
            
        }
    }
}

