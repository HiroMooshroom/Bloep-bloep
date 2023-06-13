using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    GameObject player;
    public Animator padlockAnimator;
    public Animator doorAnimator;

    private void Start()
    {
        player = GameObject.Find("player");
    }
    public void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= 3)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                padlockAnimator.SetTrigger("PadLockFalling");
                doorAnimator.SetInteger("DoorState", 1);
            }
        }
        if(player.GetComponent<Movement>().collidingDoorTrigger == true)
        {
            doorAnimator.SetInteger("DoorState", 2);
            player.GetComponent<Movement>().collidingDoorTrigger = false;
        }
    }
}
