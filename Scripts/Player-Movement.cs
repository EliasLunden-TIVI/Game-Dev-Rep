using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    public float moveSpeed = 5f;  // Change this to alter MOVEMENT SPEED: DEF = 5f

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {   
        // Gets RIGIDBODY

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // WASD AND OR ARROR KEY IMPUT
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D / Left/Right
        movement.y = Input.GetAxisRaw("Vertical");   // W/S / Up/Down
        movement = movement.normalized; // Fixes DIAGNOAL MOVEMENT BOOST
    }

    void FixedUpdate()
    {
        // Apply MOVEMENT to RIGIDBODY
        rb.velocity = movement * moveSpeed;
    }
}
aa