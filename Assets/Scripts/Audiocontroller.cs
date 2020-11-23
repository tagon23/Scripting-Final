using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Audiocontroller
{
    public static AudioSource PlayClip2D(AudioClip clip, float volume)
    {
        //create audio
        GameObject audioObject = new GameObject("2DAudio");
        AudioSource audioSource = audioObject.AddComponent<AudioSource>();
        //configure to be 2D
        audioSource.clip = clip;
        audioSource.volume = volume;
        //play
        audioSource.Play();
        //destroy
        Object.Destroy(audioObject, clip.length);
        //return
        return audioSource;
    }
}
