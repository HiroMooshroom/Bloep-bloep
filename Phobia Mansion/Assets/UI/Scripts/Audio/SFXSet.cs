using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXSet : MonoBehaviour
{
    public AudioMixer sfxMixer;

    public void SetVolume(float sfx)
    {

        sfxMixer.SetFloat("SFX", sfx);
    }
}
