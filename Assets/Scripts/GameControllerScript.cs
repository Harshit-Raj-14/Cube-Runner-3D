using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // to manage scenes in unity
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject TapToStart;
    public GameObject ScoreText;
private void Start()
{
    GameOverPanel.SetActive(false); //Switch off game over panel in the start
    TapToStart.SetActive(true);
    ScoreText.SetActive(false);
    PauseGame();
}

private void Update()
{
    if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))  //by pressing on mouse left key the game start
    {
        StartGame();
    }
}

public void GameOver()
{
    GameOverPanel.SetActive(true); //Switch on game over panel when game loses
    ScoreText.SetActive(false);
}

public void Restart()
{
    SceneManager.LoadScene("Game");    //Provide name of scene to be reoloaded
}

public void QuitGame()
{
    Application.Quit();  //This inbuilt method quits game
}

public void PauseGame()   //this keeps the game puased in start so that it only starts when clicked with lef tmouse
{
    Time.timeScale = 0f;  //keeps game paused
}

public void StartGame()
{
    Time.timeScale = 1f;   //starts game running
    TapToStart.SetActive(false);
    ScoreText.SetActive(true);
}
}
