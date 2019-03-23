using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    static MusicPlayer instance = null;

    public AudioClip[] audioClips;

    AudioSource music;

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
            music.clip = audioClips[0];
            music.loop = true;
            music.Play();
        }
    }
    private void OnLevelWasLoaded(int level)
    {
        Debug.Log("MusicPlayer: loaded level " + level);
        music.Stop();

        music.clip = audioClips[level];
        music.loop = true;
        music.Play();
    }
}

