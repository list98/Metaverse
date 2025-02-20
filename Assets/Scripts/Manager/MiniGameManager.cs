using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager instance;

    private int currentScore = 0;
    UIManager uiManager;
    public UIManager UIManager { get { return uiManager; } }

    private void Awake()
    {
        instance = this;
        uiManager = FindObjectOfType<UIManager>();
    }
    private void Start()
    {
        uiManager.UpdateScore(0);
    }
    public void LoadMiniGame()
    {
        SceneManager.LoadScene("MiniGameScene");
    }
    public void ReturnToMain()
    {
        SceneManager.LoadScene("MainScene");
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
