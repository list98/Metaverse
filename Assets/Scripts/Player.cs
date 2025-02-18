using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator = null;
    Rigidbody2D _rigidbody = null;
    void Start()
    {
        animator = transform.GetComponentInChildren<Animator>();
        _rigidbody = transform.GetComponent<Rigidbody2D>();
        if (animator == null)
        {
            Debug.LogError("Animator를 찾을 수 없습니다.");
        }

        if (_rigidbody == null)
        {
            Debug.LogError("Rigidbody를 찾을 수 없습니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
