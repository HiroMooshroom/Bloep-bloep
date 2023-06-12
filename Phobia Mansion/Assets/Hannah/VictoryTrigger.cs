using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VictoryTrigger : MonoBehaviour
{
    public GameObject victoryUI;
    public Movement movement;
    public GameObject crosshair1;
    public Interaction interaction;
    public CameraMovement cameraScript;
    public GameObject backGround;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VictoryTrigger"))
        {
            victoryUI.SetActive(true);
            movement.canMove = false;
            cameraScript.canRotate = false;
            Cursor.lockState = CursorLockMode.None;
            backGround.SetActive(true);
            


        }
    }



}
