using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AIChildren : MonoBehaviour
{
    public GameObject respawnCanvas;
    public bool died;
    public MeshRenderer player;
    public Animator animator;
    public GameObject jumpCam;
    public NavMeshAgent agent;
    public KeyPickup keyPickUp;
    public Movement movement;
    public InputMovement inputMovement;
    public AudioSource jumpScare;
    public CapsuleCollider playerCollider;
    
    

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
            playerCollider.enabled = false;
            jumpCam.SetActive(true);
            StartCoroutine(EndJump());
            agent.isStopped = true;
            died = true;
            inputMovement.canWalk = false;
            player.enabled = false;
            keyPickUp.keyPickedUp.SetActive(false);
            jumpScare.Play();
        }
    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(1f);
        respawnCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    public void RespawnButton()
    {
        movement.Death();
    }
}
