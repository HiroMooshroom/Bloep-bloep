using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CinematicCameraChange : MonoBehaviour
{
    public Movement movement;
    public AudioSource music;
    public AudioSource voiceOver;
    public GameObject cinematicCamera;

    public void Start()
    {
        if (PlayerPrefs.GetInt("CinematicHasPlayed") == 0)
        {
            StartCoroutine(EndCinematic());
        }
        if(PlayerPrefs.GetInt("CinematicHasPlayed") == 1)
        {
            cinematicCamera.SetActive(false);
            voiceOver.enabled = false;
            music.enabled = true;
            PlayerPrefs.SetInt("CinematicHasPlayed", 0);
        }
    }
    IEnumerator EndCinematic()
    {
        yield return new WaitForSeconds(27);
        cinematicCamera.SetActive(false);
        music.enabled = true;
        movement.OneTimeCinematic();
    }
}
