using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int scoreCounter = 0;

    public GameObject gameOverMenu;
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        scoreText.text = scoreCounter.ToString();
    }
    public void GameOver()
    {
        gameOverMenu.SetActive(true);
    }
    public void Restart()
    {
   SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
 
}
