using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public bool keyInRange;
    public float checkradius;
    public LayerMask keyInteraction;

    public GameObject keyObject;
    public GameObject key;
    public GameObject keyPickedUp;
    public GameObject padLock;

    public bool isKeyPickedUp;

    private void Update()
    {
        KeyPickUp();
    }
    public void KeyPickUp()
    {
        float distance = Vector3.Distance(keyObject.transform.position, transform.position);
        if (distance <= 3)
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
