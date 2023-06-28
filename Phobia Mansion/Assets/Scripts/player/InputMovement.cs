using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMovement : MonoBehaviour
{
    
    public float speed;
    Vector2 moveInput;
    Rigidbody rb;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Walk();
    }
    public void Walk()
    {
        Vector3 movingDirection = new Vector3(moveInput.x * speed, rb.velocity.y, moveInput.y * speed);
        rb.velocity = transform.TransformDirection(movingDirection);
    }
    public void OnMovement(InputValue context)
    {
        moveInput = context.Get<Vector2>();
    }
}
