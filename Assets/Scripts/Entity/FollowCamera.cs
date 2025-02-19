using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    float offsetX;

    void Start()
    {
        if (target == null)
            return;

        //ī�޶�� Ÿ�ٰ��� �Ÿ�
        offsetX = transform.position.x - target.position.x;
    }

    void Update()
    {
        if (target == null)
            return;

        //�̵��Ҷ� ī�޶� ó���� ������ �Ÿ��� �����ϸ� ����
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        transform.position = pos;

        //���� ī�޶� ��迡 �����ϸ� �Ѿ�� �ʵ��� ����
    }
}
