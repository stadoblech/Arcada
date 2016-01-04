using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    private static MusicManager instance = null;
    public AudioClip[] musicbg;
    private int i;

    public static MusicManager Instance
    {
        get { return instance; }
    }


    void Awake()
    {
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

    void Start()
    {
        i = Random.Range(0, musicbg.Length);
        StartCoroutine("Playlist");

    }

    IEnumerator Playlist()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            if (!GetComponent<AudioSource>().isPlaying)
            {
                if (i != (musicbg.Length - 1))
                {
                    i++;
                    GetComponent<AudioSource>().clip = musicbg[i];
                    GetComponent<AudioSource>().Play();
                }
                else
                {
                    i = 0;
                    GetComponent<AudioSource>().clip = musicbg[i];
                    GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}

