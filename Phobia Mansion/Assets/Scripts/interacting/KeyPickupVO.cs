using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickupVO : MonoBehaviour
{
    public AudioSource vOSource;
    public KeyPickup keyPickup;
    public bool oneTimeVO = true;
    public void Update()
    {
        if(keyPickup.isKeyPickedUp == true)
        {
            if(oneTimeVO == true)
            {
                vOSource.Play();
                oneTimeVO = false;
            }
        }
    }
}
