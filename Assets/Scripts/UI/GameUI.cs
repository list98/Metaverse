using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : BaseUI
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);

        
    }
    public void UpdateScoreText(int score)
    { 
        scoreText.text = score.ToString();
    }
    

    protected override UIState GetUIState()
    {
        return UIState.Game;
    }
}
