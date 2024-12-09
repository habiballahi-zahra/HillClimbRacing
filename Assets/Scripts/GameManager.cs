using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _restartGameCanvas;
    [SerializeField] private GameObject _HUDCanvas;


    private void Awake()
    {
        if (Instance == null)
        { Instance = this; }
        Time.timeScale = 1f;
    }
     
    public void NextLevel()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void GameOver()
    {

        _gameOverCanvas.SetActive(true);
          Time.timeScale = 0f;

    }

    public void EndGame()
    {

        _restartGameCanvas.SetActive(true);
        _HUDCanvas.SetActive(false);
        Time.timeScale = 0f;

    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

}
