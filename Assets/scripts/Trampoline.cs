using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    Animator anim;
    public float jumpForce;
    public AudioSource tramp;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("jump");
            tramp.Play();
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
        }
    }

}
