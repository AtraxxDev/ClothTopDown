using Sirenix.OdinInspector;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private PlayerAnimation _playerAnimation;

    private Vector2 moveInput;
    private Rigidbody2D rb;

    [ShowInInspector]
    private bool canMove = true;

   
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    public void ProcessInput()
    {
        if (!canMove) return;

        moveInput = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        ).normalized;

        bool isWalking = moveInput != Vector2.zero;
        _playerAnimation.ChangeWalkAnimation(isWalking);

        if (moveInput.x != 0)
        {
            Vector3 localScale = transform.localScale;
            localScale.x = moveInput.x > 0 ? 1f : -1f;
            transform.localScale = localScale;
        }
    }

    public void Move()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }

    public void SetMovementEnabled(bool value)
    {
        canMove = value;
    }

}
