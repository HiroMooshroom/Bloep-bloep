using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{

    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Game is closing");
        PlayerPrefs.SetInt("CinematicHasPlayed", 0);
    }
}
        