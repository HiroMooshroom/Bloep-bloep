using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AIChildren : MonoBehaviour
{
    public bool died;
    public NavMeshAgent agent;
    public KeyPickup keyPickUp;
    public Movement movement;

    public void Update()
    {
        if (keyPickUp.isKeyPickedUp == true)
        {
            agent.isStopped = false;
            agent.destination = transform.position;
            died = false;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ChildrenTrigger"))
        {
            agent.isStopped = true;
            died = true;
            movement.Death();
        }
    }
}
