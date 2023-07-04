using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VoiceSet : MonoBehaviour
{


    public AudioMixer VoiceMixer;

    public void SetVolume(float voiceOver)
    {

        VoiceMixer.SetFloat("VoiceOver", voiceOver);
    }


}
