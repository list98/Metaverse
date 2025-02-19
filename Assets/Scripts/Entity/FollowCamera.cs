using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    float offsetX;
    float offsetY;

    void Start()
    {
        if (target == null)
            return;

        //ī�޶�� Ÿ�ٰ��� �Ÿ�
        offsetX = transform.position.x - target.position.x;
        offsetY = transform.position.y - target.position.y;
    }

    void Update()
    {
        if (target == null)
            return;

        //�̵��Ҷ� ī�޶� ó���� ������ �Ÿ��� �����ϸ� ����
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        pos.y = target.position.y + offsetY;
        transform.position = pos;

        //���� ī�޶� ��迡 �����ϸ� �Ѿ�� �ʵ��� ����
    }
}
