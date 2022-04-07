using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
   
    public int score;
    public static GameController gc;
    public Text scoreText;
    public int totalApples;
    public GameObject message;

   

    Player player;
    bool started;
    

    // Start is called before the first frame update
    void Awake()
    {


        if (gc == null)
        {
            gc = this;
            

        }
        else if (gc != this)
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        
    }

    private void Update()
    {

    }
    
    public void ShowGameOver()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("lvl_1");

    }

    public void uptadeScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void StartGame()
    {   
        SceneManager.LoadScene("lvl_1");
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
   
}
