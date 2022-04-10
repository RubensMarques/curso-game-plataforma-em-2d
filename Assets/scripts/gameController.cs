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
    

   

    Player player;
    bool started;
    

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
        
        
        Invoke("GameOverCanvas", 22f);
        Invoke("Level", 2f);
        
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

    public void GameOverCanvas()
    {
        gameOver.SetActive(true);
    }
    
    public void Level()
    {
        level.SetActive(false);
    }

   
}
