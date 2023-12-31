using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int score;
    public Text textScore;
    public GameObject gameOver;
    public AudioSource audioSource;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        audioSource.Play();
        score += scoreToAdd;
        textScore.text = score.ToString();
    }

    public void RestartScene()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        if(CheckIfHighScore())
        {
            PlayerPrefs.SetFloat("highscore", score);
        }
    }

    public bool CheckIfHighScore()
    {
        if(PlayerPrefs.HasKey("highscore"))
        {
            float highScore = PlayerPrefs.GetFloat("highscore");
            if(highScore < score)
            {
                return true;
            }
        } else
        {
            return true;
        }
        return false;
    }


}
