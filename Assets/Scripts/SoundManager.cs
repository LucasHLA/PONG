using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundType
{
    RaqueteHit,
    WallHit,
    Victory
}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    private AudioSource audioSource;
    [SerializeField] private AudioClip[] soundList; 

    private void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    public static void PlaySound(SoundType sound, float volume = 1)
    {
        instance.audioSource.PlayOneShot(instance.soundList[(int)sound], volume);
    }
}
