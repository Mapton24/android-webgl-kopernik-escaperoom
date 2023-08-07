using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour, ICutsceneAction
{
    [SerializeField]
    private AudioSource audioSource;

    public void ExecuteAction()
    {
        PlaySound();
    }

    public void PlaySound()
    {
        if (audioSource != null)
        audioSource.Play();
    }
}
