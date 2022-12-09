using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;
    void Start()
    {
        //audioSource.clip = playlist[0];
        //audioSource.Play();
    }

    public void PlayGameStartSound()
    {
        Debug.Log("Playing audio");
        audioSource.clip = playlist[0];
        audioSource.volume = PlayerPrefs.GetFloat("volume");
        audioSource.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
