using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    static bool AudioBegin = false;
    public AudioSource audio;
    void Awake()
    {
        audio = GetComponent<AudioSource>();
        if (!AudioBegin)
        {
            audio.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        if (Application.loadedLevelName == "Upgraded")
        {
            audio.Stop();
            AudioBegin = false;
        }
    }
}