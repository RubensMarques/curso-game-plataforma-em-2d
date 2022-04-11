using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    
    

    public Button but1;
    public GameObject howToPlay, X;

     
    // Start is called before the first frame update
    void Start()
    {

        if (SceneManager.GetActiveScene().buildIndex == 6)
            but1.Select();
       
    }

    public void HowToPlay()
    {
        howToPlay.SetActive(true);
    }
    
    public void CloseHTP()
    {
        howToPlay.SetActive(false);
    }

    
}
