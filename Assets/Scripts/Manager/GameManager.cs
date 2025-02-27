using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public PlayerController player { get; private set; }

    private void Awake()
    { 
        instance = this;

        player = FindObjectOfType<PlayerController>();
        player.Init(this);
        Time.timeScale = 1.0f;
    }
    

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
