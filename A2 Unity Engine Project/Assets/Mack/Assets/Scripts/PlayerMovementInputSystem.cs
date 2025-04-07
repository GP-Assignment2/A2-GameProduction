using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementInputSystem : MonoBehaviour
{
    public float moveForce = 10f;
    public float jumpForce = 2.5f;
    public Transform respawnPoint;

    private Rigidbody rb;
    private PlayerInputActions inputActions;
    private Vector2 moveInput;
    private bool isGrounded;
    private bool jumpPressed = false;
    private bool respawnPressed = false;

    void Awake()
    {
        inputActions = new PlayerInputActions(); // Make sure PlayerInputActions is valid
        inputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputActions.Player.Move.canceled += ctx => moveInput = Vector2.zero;
        inputActions.Player.Jump.performed += ctx => jumpPressed = true;
        inputActions.Player.Respawn.performed += ctx => respawnPressed = true;

        // Verify that PlayerInputActions is valid and not null
        if (inputActions == null)
        {
            Debug.LogError("PlayerInputActions is not properly initialized.");
        }
    }


    void OnEnable() => inputActions.Enable();
    void OnDisable() => inputActions.Disable();

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (jumpPressed && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            jumpPressed = false;
        }

        if (respawnPressed)
        {
            // Reset the player's velocity and position to respawn
            rb.linearVelocity = Vector3.zero;  // Reset velocity
            rb.angularVelocity = Vector3.zero;


            // Move the player to the respawn position
            transform.position = respawnPoint.position;

            Debug.Log("Respawned!");
            respawnPressed = false;
        }
    }


    void FixedUpdate()
    {
        Vector3 force = new Vector3(moveInput.x, 0, moveInput.y) * moveForce;
        rb.AddForce(force);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.5f) // Checking if the player is grounded
            isGrounded = true;
    }
}
