using Cinemachine;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class CinematicCameraChange : MonoBehaviour
{
    public AudioSource doorShutsVO;
    public GameObject slider1, slider2;
    public GameObject door1, door2;
    public CameraMovement cmove;
    public Movement movement;
    public AudioSource music;
    public AudioSource voiceOver;
    public GameObject cinematicCamera;
    public bool canOpenDoor;
    public bool canPlayMusic;
    public float musicSaverIG;
    public AudioMixer musicMixer;
    

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
        musicSaverIG = PlayerPrefs.GetFloat("Music");
    }
    IEnumerator EndCinematic()
    {
        yield return new WaitForSeconds(29);
        cinematicCamera.SetActive(false);
        music.enabled = true;
        OneTimeCinematic();
        cmove.canRotate = true;
        door2.SetActive(false);
        door1.SetActive(true);
        slider1.SetActive(false); 
        slider2.SetActive(false);
        StartCoroutine(StartNewVO());
        doorShutsVO.Play();
        canPlayMusic = false;
        musicMixer.SetFloat("Music", -20f);
    }
    public void OneTimeCinematic()
    {
        PlayerPrefs.SetInt("CinematicHasPlayed", 1);
    }
    
    IEnumerator StartNewVO()
    {
        yield return new WaitForSeconds(31);
        canOpenDoor = true;
        canPlayMusic = true;
        musicMixer.SetFloat("Music", musicSaverIG);
    }
}
