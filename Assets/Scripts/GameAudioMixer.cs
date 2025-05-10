using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class gameAudioMixer : MonoBehaviour
{
[SerializeField] private AudioMixer audioMixer;
public void SetMasterVolume (float level){
audioMixer.SetMasterVolume( level);
}
public void SetSoundFXVolume (float level){
        audioMixer.SetSoundFXVolume( level);
    }
public void SetMusicVolume (float level){
        audioMixer.SetMusicVolume( level);
    }
}
