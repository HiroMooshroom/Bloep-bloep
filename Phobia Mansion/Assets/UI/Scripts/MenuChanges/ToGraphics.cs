using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToGraphics : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;
    public void TransitionScreen()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
}
