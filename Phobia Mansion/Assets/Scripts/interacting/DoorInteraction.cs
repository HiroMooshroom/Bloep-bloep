using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    GameObject player;
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
                doorAnimator.SetInteger("DoorState", 1);
            }
        }
    }
}
