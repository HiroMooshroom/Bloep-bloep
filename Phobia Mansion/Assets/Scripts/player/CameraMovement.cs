using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity;
    public float mouseY;
    public float mouseX;

    public float rotationX = 0f;

    public Transform playerbody;

    public bool canRotate;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (canRotate == true)
        {
            mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
            mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

            rotationX = Mathf.Clamp(rotationX, -90f, 90f);
            rotationX -= mouseY;

            playerbody.Rotate(Vector3.up * mouseX);
            transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        }   
        if (canRotate == false)
        {
            print("U cant rotate");
        }
    }
}
