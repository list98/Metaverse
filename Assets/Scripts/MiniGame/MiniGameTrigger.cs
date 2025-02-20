using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameTrigger : MonoBehaviour
{
    public GameObject miniGameButton;

    void Start()
    {
        miniGameButton.SetActive(false);
    }

    // 플레이어가 범위에 들어왔는지 확인
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
            miniGameButton.SetActive(true);
        }
    }

    // 범위에서 나가면 버튼 비활성화
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            miniGameButton.SetActive(false);
        }
    }
}