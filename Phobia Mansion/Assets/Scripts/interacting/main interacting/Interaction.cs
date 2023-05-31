using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject crosshair1, crosshair2;
    public DoorInteraction doorCanInteract;
    public string[] interactableObject;
    RaycastHit hit;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3, LayerMask.GetMask(interactableObject)))
        {
            crosshair1.SetActive(false);
            crosshair2.SetActive(true);
            doorCanInteract.canInteract = true;
        }
        else
        {
            crosshair1.SetActive(true);
            crosshair2.SetActive(false);
            doorCanInteract.canInteract = false;
        }
    }
}
