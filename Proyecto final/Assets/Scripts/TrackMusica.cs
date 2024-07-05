using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class TrackMusica : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public Button thisButton;
    public TMP_Text clipName;
    public int idTrack;

    void Start()
    {
        clipName.text = clip.name;
        audioSource = FindAnyObjectByType<AudioSource>();
        
    }

    public void PlayTrack()
    {
        audioSource.clip = clip;
        audioSource.Play();
        ReproductorMusica.instance.currentTrack = idTrack;
    }
}