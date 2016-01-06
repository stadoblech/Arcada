using UnityEngine;
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

    public AudioClip enemyHitSound;
    [Range(0f, 1f)]
    public float enemyHitVolume;

    public AudioClip[] lurkerMoveSound;
    [Range(0f, 1f)]
    public float lurkerMoveVolume;

    public AudioClip packagerSound;
    [Range(0f, 1f)]
    public float packagerVolume;

    public AudioClip respawnerSound;
    [Range(0f, 1f)]
    public float respawnerVolume;


    private static SoundEffectsManager instance = null;
    
    public static SoundEffectsManager Instance
    {
        get { return instance; }
    }

    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        if (disableSounds)
        {
            audioSource.enabled = false;
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
        //DontDestroyOnLoad(this.gameObject);
    }

    public void playerShoot()
    {
        audioSource.PlayOneShot(playerShotSound,playerShotVolume);
    }

    public void missileExplode()
    {
        audioSource.PlayOneShot(missileExplodeSound, missileExplodeVolume);
    }

    public void mineArmed()
    {
        audioSource.PlayOneShot(mineArmedSound,mineArmedVolume);
    }

    public void playerDead()
    {
        audioSource.PlayOneShot(playerDeadSound, playerDeadVolume);
    }

    public void enemyDead()
    {
        audioSource.PlayOneShot(enemyDeadSound, enemyDeadVolume);
    }

    public void enemyHit()
    {
        audioSource.PlayOneShot(enemyHitSound, enemyHitVolume);
    }

    public void lurkerMove()
    {
        AudioClip s = lurkerMoveSound[Random.Range(0,lurkerMoveSound.Length)];
        audioSource.PlayOneShot(s, lurkerMoveVolume);
    }

    public void packagerAction()
    {
        audioSource.PlayOneShot(packagerSound, packagerVolume);
    }

    public void respawnerAction()
    {
        audioSource.PlayOneShot(respawnerSound, respawnerVolume);
    }
}
