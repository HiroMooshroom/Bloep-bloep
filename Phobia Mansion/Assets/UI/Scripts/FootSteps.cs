using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource footSteps;
    public AudioClip norFoot;
    public AudioClip fleshFoot;


    public void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            footSteps.enabled = true;
        }
        else
        {
            footSteps.enabled = false;
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FleshFootsteps"))
        {
            footSteps.clip = fleshFoot;
            footSteps.Play();
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("FleshFootsteps"))
        {
            footSteps.clip = norFoot;
            footSteps.Play();
        }
    }

}


