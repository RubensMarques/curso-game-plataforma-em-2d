using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MusicController : MonoBehaviour
{
    public static MusicController instance;
    public AudioSource BGM;
    public AudioClip track0;
    public AudioClip track1;
    public AudioClip track2;
    public AudioClip track3;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if(BGM.clip != track0)
            {
                ChangeBGM(track0);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex >= 1 && SceneManager.GetActiveScene().buildIndex <6)
        {
            if(BGM.clip != track1)
            {
                ChangeBGM(track1);
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            if (BGM.clip != track2)
            {
                ChangeBGM(track2);
            }
        }if(SceneManager.GetActiveScene().buildIndex == 7)
        {
            if (BGM.clip != track3)
            {
                ChangeBGM(track3);
            }
        }

    }

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

}
