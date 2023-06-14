using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBack : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;

    public void BackToMenu()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
}

