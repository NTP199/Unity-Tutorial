using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource sfxSound;
    public BirdScript bird;

    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }

    [ContextMenu ("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (bird.birdIsAlive == true)
        {
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
            sfxSound.Play();
        }  
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
