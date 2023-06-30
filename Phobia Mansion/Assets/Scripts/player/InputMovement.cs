using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMovement : MonoBehaviour
{
    public FootSteps footsteps;
    public float speed;
    Vector2 moveInput;
    Rigidbody rb;
    public bool canWalk;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(canWalk == true)
        {
            Walk();
        }
        else
        {
            Debug.Log("you died");
        }
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
