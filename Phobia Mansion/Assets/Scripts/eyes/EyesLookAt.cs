using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesLookAt : MonoBehaviour
{
    public Transform player;

    public void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= 10)
        {
            transform.LookAt(player);
        }
    }
}
