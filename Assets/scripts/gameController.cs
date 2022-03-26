using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameController : MonoBehaviour
{

    public int score;
    public static gameController instance;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
   
}
