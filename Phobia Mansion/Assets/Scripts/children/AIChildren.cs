using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AIChildren : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public NavMeshAgent agent;
    public KeyPickup keyPickUp;

    public void Update()
    {
        if (keyPickUp.isKeyPickedUp == true)
        {
            agent.enabled = true;
            agent.destination = player.transform.position;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ChildrenTrigger"))
        {
            agent.enabled = false;
            print("you died");
        }
    }
}
