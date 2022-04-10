using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    private const int V = 0;
    public string lvlName;
    bool canNextLvl;
    Animator anim;
    //public AudioSource final;

    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        if (GameController.instance.totalApples - GameController.instance.score == V)
        {
            anim.SetBool("collected", true);
            //final.Play();
            canNextLvl = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && canNextLvl)
        {
            
            SceneManager.LoadScene(lvlName);
        }
        else
        {
            
            GameController.instance.message.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !canNextLvl)
        {
            GameController.instance.message.SetActive(false);
        }
        
    }
}
