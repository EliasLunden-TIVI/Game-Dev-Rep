using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    public float moveSpeed = 5f;  // Movement speed

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from WASD / Arrow Keys
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
        movement.y = Input.GetAxisRaw("Vertical");   // W/S or Up/Down
        movement = movement.normalized; // Prevent faster diagonal movement
    }

    void FixedUpdate()
    {
        // Apply movement to Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}
