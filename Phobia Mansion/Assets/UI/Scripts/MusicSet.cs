using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicSet : MonoBehaviour
{

    public AudioMixer musicMixer;
    public float musicSaver;

    public void Start()
    {
        PlayerPrefs.GetFloat("Music", musicSaver);
        musicMixer.SetFloat("Music", musicSaver);
    }
    public void SetVolume(float music)
    {
        PlayerPrefsSet();
        musicMixer.SetFloat("Music", music);
        musicSaver = music; 
    }
    public void PlayerPrefsSet()
    {
        PlayerPrefs.SetFloat("Music", musicSaver);
    }

    
}
