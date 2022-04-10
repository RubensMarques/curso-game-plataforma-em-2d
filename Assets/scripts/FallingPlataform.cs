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

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Falling", 0.2f);
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
