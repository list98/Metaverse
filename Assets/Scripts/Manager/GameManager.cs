using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int currentMiniGameScore = 0;
    public PlayerController player { get; private set; }

    private void Awake()
    { 
        instance = this;

        player = FindObjectOfType<PlayerController>();
        player.Init(this);
    }
    

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
