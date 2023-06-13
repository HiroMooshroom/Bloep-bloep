using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAndKeyInteraction : MonoBehaviour
{
    public KeyPickup keyPickup;
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
            if(Input.GetKeyDown(KeyCode.E))
            {
                if (keyPickup.isKeyPickedUp == true)
                {
                    padlockAnimator.SetTrigger("PadLockFalling");
                    doorAnimator.SetInteger("DoorState", 1);
                    keyPickup.keyPickedUp.SetActive(false);
                    keyPickup.isKeyPickedUp = false;
                }
            }
        }
        if (player.GetComponent<Movement>().collidingDoorTrigger == true)
        {
            doorAnimator.SetInteger("DoorState", 2);
            player.GetComponent<Movement>().collidingDoorTrigger = false;
        }
    }
}
