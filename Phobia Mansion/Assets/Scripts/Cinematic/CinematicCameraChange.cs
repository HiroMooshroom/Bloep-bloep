using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CinematicCameraChange : MonoBehaviour
{
    public GameObject slider1, slider2;
    public GameObject door1, door2;
    public CameraMovement cmove;
    public Movement movement;
    public AudioSource music;
    public AudioSource voiceOver;
    public GameObject cinematicCamera;
    

    public void Start()
    {
        if (PlayerPrefs.GetInt("CinematicHasPlayed") == 0)
        {
            StartCoroutine(EndCinematic());
            cmove.canRotate = false;
        }
        if(PlayerPrefs.GetInt("CinematicHasPlayed") == 1)
        {
            cinematicCamera.SetActive(false);
            voiceOver.enabled = false;
            music.enabled = true;
            door2.SetActive(false);
            slider1.SetActive(false);
            slider2.SetActive(false);
        }
    }
    IEnumerator EndCinematic()
    {
        yield return new WaitForSeconds(27);
        cinematicCamera.SetActive(false);
        music.enabled = true;
        OneTimeCinematic();
        cmove.canRotate = true;
        door2.SetActive(false);
        door1.SetActive(true);
        slider1.SetActive(false); 
        slider2.SetActive(false);
    }
    public void OneTimeCinematic()
    {
        PlayerPrefs.SetInt("CinematicHasPlayed", 1);
    }
}
