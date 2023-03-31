using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // loads the Sample scene
	public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    // loads the Sample scene
    public void ResetGame()
    {
        ResetBall.max = 2;
        ResetBall.resetCount = 0;
        ScoringSystem.score = 0;
        StartGame();
    }
    // loads the Menu scene
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }// loads the high score scene
    public void HighScoreMenu()
    {
        SceneManager.LoadScene("HighScore");
    }// loads the Menu scene
    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }// quit application
    public void QuitGame()
    {
        Application.Quit();
    }
}
