using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class musicManagerScript : MonoBehaviour
{
    private AudioSource musicSource;
    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        musicSource.mute = PlayerPrefs.GetInt("MusicMuted", 0) == 1;
    }
}
