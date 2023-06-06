using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using static Unity.VisualScripting.Metadata;

public class AIChildren : MonoBehaviour
{
    public bool died;
    public GameObject player;
    public GameObject children;
    public float moveSpeed;
    public NavMeshAgent agent;
    public KeyPickup keyPickUp;
    public GameObject spawnPoint;
    public GameObject childStartPoint;
    public KeyPickup keyScript;

    public void Update()
    {
        if (keyPickUp.isKeyPickedUp == true)
        {
            agent.isStopped = false;
            agent.destination = player.transform.position;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ChildrenTrigger"))
        {
            player.transform.position = spawnPoint.transform.position;
            children.transform.position = childStartPoint.transform.position;
            agent.isStopped = true;
            keyScript.key.SetActive(true);
            keyScript.keyPickedUp.SetActive(false);
            keyScript.isKeyPickedUp = false;
        }
    }
}
