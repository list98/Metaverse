using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager instance;
    public MiniGamePlayer player { get; private set; }

    [SerializeField]private int currentScore = 0;

    UIManager uiManager;

    private void Awake()
    {
        instance = this;
        uiManager = FindObjectOfType<UIManager>();
    }
    private void Start()
    {
        
    }
    public void LoadMiniGame()
    {
        SceneManager.LoadScene("MiniGameScene");
        Time.timeScale = 0.0f;
    }
    public void ReturnToMain()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1.0f;
    }
    public void StartGame()
    {
        uiManager.SetPlayGame();
        StartAddScore();

    }
    void StartAddScore()
    { 
        currentScore = currentScore + 1;
        uiManager.UpdateScore(currentScore);
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        uiManager.SetGameOver();
    }
    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log($"Score" + currentScore);
        uiManager.UpdateScore(currentScore);
    }
}
