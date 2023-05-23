using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float sensitivity;
    public float mouseY;
    public float mouseX;

    public float rotationX = 0f;

    public Transform playerbody;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        rotationX -= mouseY;

        playerbody.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}
