using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
//script for creating a custom Sound editor for each sound instance, this makes it easier to manage sounds in a sound manager.

[System.Serializable]
public class Sound 
{
    public string name;
    public AudioClip clip;
    public AudioMixerGroup Output;

    [Range(0f, 1f)]
    public float Volume;


    [HideInInspector]
    public AudioSource source;
   
}
