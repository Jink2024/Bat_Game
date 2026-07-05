
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using Vector2 = UnityEngine.Vector2;

public class DGMovement : MonoBehaviour
{
    public DGGame DGGame;
    public GameObject BatGameObject;
    public SpriteRenderer spriteRenderer;
    
    public float jumpForce = 5f; // Adjust this value to control the jump force.
    private Rigidbody2D rb;
    private RigidbodyConstraints2D OriginalrbConstraints;

    void Awake()
    {
        rb = BatGameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        OriginalrbConstraints = rb.constraints;
        //rbConstraints = BatGameObject.GetComponent<RigidbodyConstraints2D>();
    }

    public void UnFreezeBat()
    {
        rb.gravityScale = 1;
        //rb.linearVelocity = rb.linearVelocity.normalized;
        rb.constraints = OriginalrbConstraints;
    }
    
    public void FreezeBat()
    {
        rb.gravityScale = 0f;
        //rb.linearVelocity = Vector2.zero;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }
    void Start()
    {
    }

    void Update()
    {
        
        if (!DGGame.IsGameRunning())
        {
            print("Gamenotrunning");
            FreezeBat();
            return;
        }
        
            print("Game Running");
            
            UnFreezeBat();
            Move(Vector2.right);

            if (Keyboard.current.spaceKey.wasPressedThisFrame)
                //(Input.GetMouseButtonDown(0)) // Check for mouse click or tap.
            {
                Jump();
            }
    }

    void Jump()
    {
        // Make the bird jump by applying an upward force.
        rb.linearVelocity = Vector2.up * jumpForce;
    }

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        // Handle collisions with obstacles (pipes, ground, etc.).
        // You can implement game over logic here.

        if (other.CompareTag("SlotTrigger"))
        {
            
            // game over
            DGGame.GameOver();
            print("hit wall");
            // should prolly stop bat movement?
        }
    }

    public void Move(Vector2 direction)
    {
        // Useless for now, could be used later.
        //FaceCorrectDirection(direction);
        
        Vector2 movementAmount = direction * (5f * Time.deltaTime);
        
        spriteRenderer.transform.Translate(movementAmount.x,0,0);

        //spriteRenderer.transform.position = SpriteTools.ConstrainToScreen(spriteRenderer);
    }
    
    
}
