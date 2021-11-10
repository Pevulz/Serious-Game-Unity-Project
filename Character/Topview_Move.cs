// Top view movement
// Set gravity scale to 0
// Checkbox for Freeze Rotation Z
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed = 5f;
	public Rigidbody2D rb;
    // Animator component 
    // public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // For Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        // Animator component
        // animator.SetFloat("Horizontal", movement.x);
        // animator.SetFloat("Vertical", movement.y);
        // animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // For movement
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime);
    }

}
