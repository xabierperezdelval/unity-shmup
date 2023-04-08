using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 moveVal;
    public float moveSpeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
        moveSpeed = 5;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVal * moveSpeed * Time.fixedDeltaTime);
    }
}
