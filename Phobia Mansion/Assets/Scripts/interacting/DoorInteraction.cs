using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Interaction interaction;
    GameObject player;
    public Animator padlockAnimator;
    public Animator doorAnimator;
    public bool canInteract;
    private void Start()
    {
        player = GameObject.Find("player");
    }
    public void Update()
    {
        if (canInteract == true)
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
        }
    }
    
}
