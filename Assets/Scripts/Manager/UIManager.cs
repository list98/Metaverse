using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum UIState
{
    Game,
    Score,
}

public class UIManager : MonoBehaviour
{
    static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            return instance;
        }
    }

    UIState currentState = UIState.Game;


    
    GameUI gameUI = null;
    ScoreUI scoreUI = null;

    Obstacle obstacle = null;
    private void Awake()
    {
        instance = this;
        obstacle = FindObjectOfType<Obstacle>();

        gameUI = GetComponentInChildren<GameUI>(true);
        gameUI?.Init(this);
        scoreUI = GetComponentInChildren<ScoreUI>(true);
        scoreUI?.Init(this);

        ChangeState(UIState.Game);
    }


    public void ChangeState(UIState state)
    {
        currentState = state;
        
        gameUI?.SetActive(currentState);
        scoreUI?.SetActive(currentState);
    }

    public void OnClickStart()
    {
        ChangeState(UIState.Game);
    }

    public void OnClickExit()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void SetGameOver()
    {
        ChangeState(UIState.Score);
    }

    public void UpdateScore(int score)
    {
        gameUI.UpdateScoreText(score);
    }
    
}