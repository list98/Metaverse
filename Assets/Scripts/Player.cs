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
            Debug.LogError("Animator�� ã�� �� �����ϴ�.");
        }

        if (_rigidbody == null)
        {
            Debug.LogError("Rigidbody�� ã�� �� �����ϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
