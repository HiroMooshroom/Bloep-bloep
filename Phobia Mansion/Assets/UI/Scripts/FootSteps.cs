using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource footSteps;
    public AudioSource fleshFoot;


    public void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
            {
            if (CompareTag("NorFootsteps"))
            {

                footSteps.enabled = true;
                fleshFoot.enabled = false;
            }

            if(CompareTag("FleshFootsteps"))
            {
                footSteps.enabled = false;
                fleshFoot.enabled = true;
            }

            }
       
        
    }

   

}


