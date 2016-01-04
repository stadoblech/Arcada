﻿using UnityEngine;
using System.Collections;

public class SoundEffectsManager : MonoBehaviour {

    public bool disableSounds;

    public AudioClip playerShotSound;
    [Range(0f, 1f)]
    public float playerShotVolume;

    public AudioClip playerDeadSound;
    [Range(0f, 1f)]
    public float playerDeadVolume;

    public AudioClip enemyDeadSound;
    [Range(0f, 1f)]
    public float enemyDeadVolume;

    public AudioClip missileExplodeSound;
    [Range(0f, 1f)]
    public float missileExplodeVolume;

    public AudioClip mineArmedSound;
    [Range(0f, 1f)]
    public float mineArmedVolume;


    private static SoundEffectsManager instance = null;
    
    public static SoundEffectsManager Instance
    {
        get { return instance; }
    }

    private AudioSource audio;

    void Awake()
    {
        audio = GetComponent<AudioSource>();

        if (disableSounds)
        {
            audio.enabled = false;
        }

        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void playerShoot()
    {
        audio.PlayOneShot(playerShotSound,playerShotVolume);
    }

    public void missileExplode()
    {
        audio.PlayOneShot(missileExplodeSound, missileExplodeVolume);
    }

    public void mineArmed()
    {
        audio.PlayOneShot(mineArmedSound,mineArmedVolume);
    }

    public void playerDead()
    {
        audio.PlayOneShot(playerDeadSound, playerDeadVolume);
    }

    public void enemyDead()
    {
        audio.PlayOneShot(enemyDeadSound, enemyDeadVolume);
    }
}
