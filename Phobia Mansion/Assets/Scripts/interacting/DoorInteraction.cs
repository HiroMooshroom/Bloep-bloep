using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Interactable interaction;
    public Animator padlockAnimator;
    public Animator doorOpening;
    public void Update()
    {
        if (interaction.interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                padlockAnimator.SetTrigger("PadLockFalling");
                doorOpening.SetTrigger("DoorOpen");
            }
        }
    }
}
