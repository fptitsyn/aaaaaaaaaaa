using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private float movementX;
    private Rigidbody2D body;

    [SerializeField] 
    private float jumpForce = 8f;

    private bool isGrounded;
    
    void Awake()
    {
        Debug.Log("SEX");
    }

    private void Update()
    {
        HandlePlayerMovement();
        HandleJumping();
    }

    void HandlePlayerMovement()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * (moveSpeed * Time.deltaTime);
    }

    void HandleJumping()
    {
        
    }
}
