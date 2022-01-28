using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip audio;

    void Start ()
    {
        //audio = GetComponent<AudioSource>();
    }
    public void OnClick ()
    {        
        GetComponent<AudioSource>().PlayOneShot(audio);
    }    
}
