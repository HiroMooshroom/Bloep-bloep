using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicSet : MonoBehaviour
{

    public AudioMixer musicMixer; 

    public void SetVolume(float music)
    {
       
        musicMixer.SetFloat("Music", music);
    }

    
}
