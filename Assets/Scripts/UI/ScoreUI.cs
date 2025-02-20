using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreUI : BaseUI
{
    [SerializeField] private Button minigameButton;
    [SerializeField] private Button exitButton;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI bestscoreText;

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);

        minigameButton.onClick.AddListener(OnClickeStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }
    public void OnClickeStartButton()
    {
        uiManager.SetPlayGame();
    }
    public void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1.0f;
    }
    

    public void UpdateScoreText(int score, int bestscore)
    {
        scoreText.text = score.ToString();
        bestscoreText.text = bestscore.ToString();
    }

    protected override UIState GetUIState()
    {
        return UIState.Score;
    }
}
