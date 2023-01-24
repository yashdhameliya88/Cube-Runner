using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tapStart;
    public GameObject scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        
        PauseGame();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
        
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreBoard.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("CubeRunner");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        tapStart.SetActive(true);
        scoreBoard.SetActive(false);
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        tapStart.SetActive(false);
        scoreBoard.SetActive(true);
        Time.timeScale = 1f;
    }
}
