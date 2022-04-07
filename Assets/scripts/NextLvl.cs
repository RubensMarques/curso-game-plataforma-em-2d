using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{

    public string lvlName;
    bool canNextLvl;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        if (GameController.gc.totalApples - GameController.gc.score == 0)
        {
            anim.SetBool("collected", true);
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
            GameController.gc.message.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !canNextLvl)
        {
            GameController.gc.message.SetActive(false);
        }
        
    }
}
