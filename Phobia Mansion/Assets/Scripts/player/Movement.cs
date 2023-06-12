using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    public float horizontal;
    public float vertical;
    public bool collidingDoorTrigger;
    public Vector3 moveDirection;
    public bool canMove = true;

    void Update()
    {
        if (canMove ==  true)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            moveDirection.x = horizontal;
            moveDirection.z = vertical;

            transform.Translate(moveDirection * speed * Time.deltaTime);
        }
        if(canMove == false)
        {
            print("you cannot move");
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerDoorClosing"))
        {
            collidingDoorTrigger = true;
        }
        else
        {
            collidingDoorTrigger = false;
        }
    }
}
