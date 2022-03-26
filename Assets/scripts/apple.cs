using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    Animator anim;
    int apples=10;

    // Start is called before the first frame update
    void Start()
    {
       
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("collected", true);
            GameController.instance.score += apples;
            GameController.instance.UpdateScoreText();
            Destroy(gameObject, 0.5f);
        }
    }
}
