using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public bool keyInRange;
    public float checkradius;
    public LayerMask keyInteraction;

    public GameObject key;
    public GameObject keyPickedUp;
    public GameObject padLock;

    public bool isKeyPickedUp;
    public bool isKeyUsed;

    private void Update()
    {
        KeyPickUp();
    }
    public void KeyPickUp()
    {
        keyInRange = Physics.CheckSphere(transform.position, checkradius, keyInteraction);
        if (keyInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                key.SetActive(false);
                keyPickedUp.SetActive(true);
                isKeyPickedUp = true;
            }
        }

    }
}
