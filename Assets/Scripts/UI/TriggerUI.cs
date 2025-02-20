using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerUI : BaseUI
{
    [SerializeField] private Button minigameButton;

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);

        minigameButton.onClick.AddListener(OnClickeStartButton);
    }
    public void OnClickeStartButton()
    {
        SceneManager.LoadScene("MiniGameScene");
        Time.timeScale = 0.0f;
    }
    protected override UIState GetUIState()
    {
        return UIState.Trigger;
    }
}
