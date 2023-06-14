using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrypoTrigger : MonoBehaviour
{
    public float trypoStrength;
    public Renderer rend;
    public float time;
    public bool startTrypo;

    public void Update()
    {
        if(startTrypo == true)
        {
            trypoStrength += time * Time.deltaTime;
            rend.material.SetFloat("_Strength", trypoStrength);
            if(trypoStrength >= 0.75f)
            {
                startTrypo = false;
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TrypoTrigger"))
        {
            startTrypo = true;
        }
    }
}
