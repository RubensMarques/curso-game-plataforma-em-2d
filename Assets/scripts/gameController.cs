using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
   
    public int score;
    public static GameController instance;
    public Text scoreText;
    public int totalApples;
    public GameObject message, gameOver, level;
   

    // Start is called before the first frame update
    void Awake()
    {


        if (instance == null)
        {
            instance = this;
            

        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        
        
        Invoke(nameof(GameOverCanvas), 22f);
        Invoke(nameof(Level), 2f);
        
    }
    
    public void ShowGameOver()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("lvl_1");

    }

    public void UptadeScore()
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
        
        Application.Quit();
    }

    public void GameOverCanvas()
    {
        gameOver.SetActive(true);
    }
    
    public void Level()
    {
        level.SetActive(false);
    }

   
}
