using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    public void PlaySound()
    {
        if (audioSource != null)
        audioSource.Play();
    }
}
