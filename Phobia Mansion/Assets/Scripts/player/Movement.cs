using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    public float horizontal;
    public float vertical;
    public bool colliding;
    public Vector3 moveDirection;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        moveDirection.x = horizontal;
        moveDirection.z = vertical;

        transform.Translate(moveDirection * speed * Time.deltaTime);

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerDoorClosing"))
        {
            colliding = true;
        }
        else
        {
            colliding = false;
        }
    }
}
