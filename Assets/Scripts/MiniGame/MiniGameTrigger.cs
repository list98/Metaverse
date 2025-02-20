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

    // �÷��̾ ������ ���Դ��� Ȯ��
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
            miniGameButton.SetActive(true);
        }
    }

    // �������� ������ ��ư ��Ȱ��ȭ
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            miniGameButton.SetActive(false);
        }
    }
}