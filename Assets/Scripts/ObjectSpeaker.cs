using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpeaker : MonoBehaviour
{
    public AudioClip intro;
    
    // Colours
    public AudioClip red;
    public AudioClip blue;
    public AudioClip green;
    public AudioClip yellow;

    // Qualities
    public AudioClip broken;
    public AudioClip rusty;
    public AudioClip shiny;
    public AudioClip standard;

    // Shapes
    public AudioClip triangle;
    public AudioClip circle;
    public AudioClip square;
    public AudioClip freeform;

    // Speak method
    public void Speak(Object objectToSpeak)
    {
        AudioSource source = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
        source.clip = intro;
        StartCoroutine(playIntro(source, objectToSpeak));
    }

    IEnumerator playIntro(AudioSource source, Object objectToSpeak)
    {
        source.Play();
        yield return new WaitWhile(() => source.isPlaying);
        StartCoroutine(playQuality(source, objectToSpeak));
    }

    IEnumerator playQuality(AudioSource source, Object objectToSpeak)
    {
        switch(objectToSpeak.objectQuality.ToString())
        {
            case "shiny":
                source.clip = shiny;
                break;
            case "rusty":
                source.clip = rusty;
                break;
            case "broken":
                source.clip = broken;
                break;
            case "standard":
                source.clip = standard;
                break;
        }
        source.Play();
        yield return new WaitWhile(() => source.isPlaying);
        StartCoroutine(playColour(source, objectToSpeak));
    }

    IEnumerator playColour(AudioSource source, Object objectToSpeak)
    {
        switch (objectToSpeak.objectColour.ToString())
        {
            case "red":
                source.clip = red;
                break;
            case "blue":
                source.clip = blue;
                break;
            case "green":
                source.clip = green;
                break;
            case "yellow":
                source.clip = yellow;
                break;
        }
        source.Play();
        yield return new WaitWhile(() => source.isPlaying);
        StartCoroutine(playShape(source, objectToSpeak));
    }

    IEnumerator playShape(AudioSource source, Object objectToSpeak)
    {
        switch (objectToSpeak.objectShape.ToString())
        {
            case "triangle":
                source.clip = triangle;
                break;
            case "circle":
                source.clip = circle;
                break;
            case "square":
                source.clip = square;
                break;
            case "freeform":
                source.clip = freeform;
                break;
        }
        source.Play();
        yield return new WaitWhile(() => source.isPlaying);
    }
}
