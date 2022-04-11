using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlataform : MonoBehaviour
{
    TargetJoint2D target;
    BoxCollider2D box;
    Animator anim;
    public AudioSource plat;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        box = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke(nameof(Falling), 0.2f);
        }

        if(collision.gameObject.layer == 9)
        {
            plat.Play();
            anim.SetBool("destroy", true);
            Destroy(gameObject, 0.3f);
        }
    }

    void Falling()
    {
        target.enabled = false;
        
    }
}
