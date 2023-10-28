using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip launchSound;
    public AudioClip collisionSound;
    public AudioClip slotSound;
    public AudioClip victorySound;

    public void PlayLaunchSound()
    {
        audioSource.PlayOneShot(launchSound);
    }

    public void PlayCollisionSound()
    {
        audioSource.PlayOneShot(collisionSound);
    }

    public void PlaySlotSound()
    {
        audioSource.PlayOneShot(slotSound);
    }

    public void PlayVictorySound()
    {
        audioSource.PlayOneShot(victorySound);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        PlayCollisionSound();
    }

}


