using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    protected AnimationHandler animationHandler;
    protected StatHandler statHandler;

    [SerializeField] private SpriteRenderer chracterRenderer;

    protected Vector2 movementDirection = Vector2.zero;
    public Vector2 MovementDirection { get { return movementDirection; } }


    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        animationHandler = GetComponent<AnimationHandler>();
        statHandler = GetComponent<StatHandler>();
    }
    protected virtual void Start()
    {

    }


    protected virtual void Update()
    {
        HandleAction();
    }
    protected virtual void FixedUpdate()
    {
        Movement(movementDirection);
    }
    protected virtual void HandleAction()
    { 
        
    }
    private void Movement(Vector2 direction)
    {
        direction = direction * statHandler.moveSpeed;

        _rigidbody.velocity = direction;
        animationHandler.Move(direction);
    }

    protected void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Mathf.Rad2Deg ������ ��ȯ���ִ� ���
        bool isLeft = Mathf.Abs(rotZ) > 90f; // 90�� �̻��̸� ������ �ٶ󺸰� �ִ� ��

        chracterRenderer.flipX = isLeft;
    }
}
