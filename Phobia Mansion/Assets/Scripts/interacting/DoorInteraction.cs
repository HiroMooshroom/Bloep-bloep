using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Interactable interaction;
    GameObject player;
    public Animator padlockAnimator;
    public Animator doorAnimator;
    private void Start()
    {
        player = GameObject.Find("player");
    }
    public void Update()
    {
        if (interaction.interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                padlockAnimator.SetTrigger("PadLockFalling");
                doorAnimator.SetInteger("DoorState", 1);

            }
        }
        if(player.GetComponent<Movement>().colliding == true)
        {
            doorAnimator.SetInteger("DoorState", 2);
        }
    }
    
}
