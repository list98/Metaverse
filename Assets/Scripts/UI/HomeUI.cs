using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class HomeUI : BaseUI
{
    [SerializeField] private Button minigameButton;
    [SerializeField] private Button exitButton;

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
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainScene");
    }
    protected override UIState GetUIState()
    {
        return UIState.Home;
    }
}
