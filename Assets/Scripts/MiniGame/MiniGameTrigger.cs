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
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            miniGameButton.SetActive(true);
        }
    }

    // �������� ������ ��ư ��Ȱ��ȭ
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            miniGameButton.SetActive(false);
        }
    }
}