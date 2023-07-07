using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenVCDone : MonoBehaviour
{
    GameObject player;
    public Animator doorAnimator;
    public CinematicCameraChange openDoor;
    public Canvas cantOpen;

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
                if(openDoor.canOpenDoor == false)
                {
                    StartCoroutine(CantOpenCanvas());
                    cantOpen.enabled = true;
                }
                if(openDoor.canOpenDoor == true)
                {
                    doorAnimator.SetInteger("DoorState", 1);
                }
            }
        }
    }
    IEnumerator CantOpenCanvas()
    {
        yield return new WaitForSeconds(2);
        cantOpen.enabled = false;
        
    }
}
