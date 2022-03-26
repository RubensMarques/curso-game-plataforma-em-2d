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
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void restart(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
   
}
