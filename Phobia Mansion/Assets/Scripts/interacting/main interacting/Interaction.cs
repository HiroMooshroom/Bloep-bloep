using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class Interaction : MonoBehaviour
{
    public GameObject crosshair1, crosshair2;
    public TMP_Text interact;
    RaycastHit hit;
    public bool canInteract;
    public LayerMask layer;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3, layer))
        {
            crosshair1.SetActive(false);
            crosshair2.SetActive(true);
            interact.enabled = true;
            canInteract = true;
            
        }
        else
        {
            crosshair1.SetActive(true);
            crosshair2.SetActive(false);
            interact.enabled = false;
            canInteract = false;
            
        }
    }
}
