using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    Vector2 movementInput;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    bool canMove = true;

    float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // called so many times a second; used for physics stuff
    private void FixedUpdate()
    {
        if (canMove)
        {
            // If movement is not 0, try to move
            if (movementInput != Vector2.zero)
            {
                bool success = TryMove(movementInput);
                if (!success)
                {
                    success = TryMove(new Vector2(movementInput.x, 0));
                }
                if (!success)
                {
                    success = TryMove(new Vector2(0, movementInput.y));
                }
            }

            // Set direction of sprite to movement direction
            if (movementInput.x < 0)
            {
                if (rotation != 90)
                {
                    rotation = 90;
                }
            }
            else if (movementInput.x > 0)
            {
                if (rotation != -90)
                {
                    rotation = -90;
                }
            }

            if (movementInput.y < 0)
            {
                if (rotation != 180)
                {
                    rotation = 180;
                }
            }
            else if (movementInput.y > 0)
            {
                if (rotation != 0)
                {
                    rotation = 0;
                }
            }
            transform.localRotation = Quaternion.Euler(0, 0, rotation);
        }
    }

    private bool TryMove(Vector2 direction)
    {
        if (direction == Vector2.zero) { return false; }

        int count = rb.Cast(
            direction, // XY between -1 and 1 for direction movement 
            movementFilter, // settings that determine where a collision can occur
            castCollisions, // list of collisions to store found collisions in 
            moveSpeed * Time.fixedDeltaTime + collisionOffset); // magnitude of ray

        if (count == 0)
        {
            rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
            return true;
        }
        else
        {
            return false;
        }
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }

    void OnFire()
    {
        // whenever player clicks
    }

    void OnLeave()
    {
        SceneManager.LoadScene(0);
    }

    public void Defeated()
    {
        SceneManager.LoadScene(0);
    }
}