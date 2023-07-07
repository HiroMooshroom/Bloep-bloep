using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMusic : MonoBehaviour
{
    public AudioSource music;
    public AudioClip lobbiMusic;
    public AudioClip ambMusic;




    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LobbyMusicSwitch"))
        {
            music.clip = lobbiMusic;
            music.Play();
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LobbyMusicSwitch"))
        {
            music.clip = ambMusic;
            music.Play();
        }
    }

}
