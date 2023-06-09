using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    bool IsMoving { 
        set {
            isMoving = value;
            animator.SetBool("isMoving", isMoving);

            if(isMoving) {
                rb.drag = moveDrag;
            } else {
                rb.drag = stopDrag;
            }
        }
    }

    public float moveSpeed = 1250f;

    // Drag when player is moving around the level
    public float moveDrag = 15f;
    
    // Drag when player is not able or trying to move
    public float stopDrag = 25f;

    public bool canAttack = true;
    public string attackAnimName = "swordAttack";

    public ParticleSystem dust;

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    
    Collider2D swordCollider;
    Vector2 moveInput = Vector2.zero;

    bool isMoving = false;
    bool canMove = true;


    void Start(){
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator.SetBool("canAttack", canAttack);
    }

    void FixedUpdate() {
        
        if(canMove == true && moveInput != Vector2.zero) {

            // Move animation and add velocity
            // Accelerate the player while run direction is pressed (limited by rigidbody linear drag)
            rb.AddForce(moveInput * moveSpeed * Time.fixedDeltaTime, ForceMode2D.Force);
    
            // Control whether looking left or right
            if(moveInput.x > 0) {
                spriteRenderer.flipX = false;
                gameObject.BroadcastMessage("IsFacingRight", true);
            } else if (moveInput.x < 0) {
                spriteRenderer.flipX = true;
                gameObject.BroadcastMessage("IsFacingRight", false);
            }
                createDust();
            IsMoving = true;

        } else {
            IsMoving = false;
        }
    }

    // Get input values for player movement
    void OnMove(InputValue value) {
        moveInput = value.Get<Vector2>();
    }

    // Play Attack animation and try to do damage
    void OnFire() {
        if(canAttack) {
            animator.SetTrigger(attackAnimName);
        }
    }

    void LockMovement() {
        canMove = false;
    }

    void UnlockMovement() {
        canMove = true;
    }

    void createDust() {
        dust.Play();
    }
}
