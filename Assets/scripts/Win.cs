using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject panel;
    public Rigidbody2D credits;
    Rigidbody2D player;
    Animator anim;
    bool jump;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("MainMenu", 55f);
        Invoke("ClosePanel", 29f);
        credits.position += new Vector2(credits.velocity.x, Time.deltaTime*60);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            jump = true;
            if (jump)
               // anim.SetBool("jump", false);
                player.velocity = Vector2.up * 9;
                
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (jump)
                //anim.SetBool("jump", true);
                jump = false;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
    
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
