using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeLogicScript : MonoBehaviour
{


    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("highscore"))
        {
            highScore.text = highScore.text +  Convert.ToString(PlayerPrefs.GetFloat("highscore"));
        } else
        {
            highScore.text = highScore.text + "0";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");    
    }

}
