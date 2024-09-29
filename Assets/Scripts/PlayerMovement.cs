using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 move_input;
    public bool isMoving { get; private set; }
    [SerializeField] float speed;

    Rigidbody2D rb;
    [SerializeField] float jumpImpulse;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move_input.x * speed, rb.velocity.y);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move_input = context.ReadValue<Vector2>();

        isMoving = move_input != Vector2.zero;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpImpulse);
        }
    }
}
