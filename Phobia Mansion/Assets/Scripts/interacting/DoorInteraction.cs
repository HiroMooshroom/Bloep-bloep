using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Interactable interaction;

    public void Update()
    {
        if (interaction.interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);
            }
        }
    }
}
