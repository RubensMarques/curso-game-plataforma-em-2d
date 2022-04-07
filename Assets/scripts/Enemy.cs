using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float  movTime, timer, speed;
    
    public bool dirRight=true;
    
   
    Rigidbody2D enemy;
    
    
    Animator anim;
   
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
        
        anim = GetComponent<Animator>();
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (dirRight)
        {
            
            enemy.position += new Vector2(Time.deltaTime * speed, enemy.velocity.y);
            


        }
        else
        {
            enemy.position += new Vector2(-Time.deltaTime * speed, enemy.velocity.y);
            
        }

        timer += Time.deltaTime;

        if(timer >= movTime)
        {
            dirRight = !dirRight;
            timer = 0f;
        }

    }
    
    

}
