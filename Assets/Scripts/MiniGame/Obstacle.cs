using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    GameManager gameManager;
    //오브젝트 상하로 이동시킬 값
    public float highPosY = 1f;
    public float lowPosY = -1f;

    //오브젝트간 공간 사이즈
    public float holeSizeMin = 1f;
    public float holeSizeMax = 3f;

    public Transform topObject;
    public Transform bottomObject;

    //오브젝트 사이 폭거리
    public float widthPadding = 4f;

    private void Start()
    {
        gameManager = GameManager.instance;
    }
    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstacleCount)
    { 
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObject.localPosition = new Vector3(0, halfHoleSize);
        bottomObject.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = placePosition;

        return placePosition;
    }
    // 트리거에서 나갈때마다 점수 1점 추가
    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();
        if (player != null)
            gameManager.AddScore(1);

        
    }

}
