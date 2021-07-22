using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCaller : MonoBehaviour
{
   //this script can be applied to any Game object to play any sound from the soundManager using the LoadSoundEvent Method.
    public string SoundName;



    public void LoadsoundEvent()
    {
        FindObjectOfType<SoundManager>().play(SoundName);
        Debug.Log("Sound " + SoundName);
        
    }

    
//Use this is any script to call a sound from the sound Manager & play it
    /*FindObjectOfType<SoundManager>().play("SoundName");*/




}
