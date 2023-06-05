using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    public float maxStam = 100;
    public float minStam = 0;
    public float stamina = 100;
    public float stamCon = 20;
    public float stamRec = 10;
    public float distance;
    public bool isSprinting;
    public Movement speed;
    public Slider staminaShower;

    public void Update()
    {
        staminaShower.value = stamina;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
        }

        if (isSprinting)
        {
            if (stamina > minStam)
            {
                stamina -= stamCon * Time.deltaTime;
                distance += Time.deltaTime;
                speed.speed = 10f;
            }
        }
        else
        {
            speed.speed = 5f;
            if (stamina < maxStam)
            {
                stamina += stamRec * Time.deltaTime;
                distance = 0f;
            }
        }
        if (stamina <= minStam)
        {
            speed.speed = 5f;
        }
    }
}
