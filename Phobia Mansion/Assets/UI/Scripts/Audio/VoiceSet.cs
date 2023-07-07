using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VoiceSet : MonoBehaviour
{
    public AudioMixer VoiceMixer;
    public float voSaver;
    public Slider voSlider;

    public void Start()
    {
        voSlider.value = PlayerPrefs.GetFloat("VO", voSaver);
    }
    public void SetVolume(float vo)
    {
        VoiceMixer.SetFloat("VO", vo);
        voSaver = vo;
        VoPlayerPrefsSet();
    }
    public void VoPlayerPrefsSet()
    {
        PlayerPrefs.SetFloat("VO", voSaver);
    }


}
