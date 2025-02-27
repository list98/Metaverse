using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameFollowCamera : MonoBehaviour
{
    public Transform target;
    float offsetX;

    void Start()
    {
        if (target == null)
            return;

        //카메라와 타겟과의 거리
        offsetX = transform.position.x - target.position.x;
    }

    void Update()
    {
        if (target == null)
            return;

        //이동할때 카메라가 처음에 떨어진 거리를 유지하며 따라감
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        transform.position = pos;

    } 
}
