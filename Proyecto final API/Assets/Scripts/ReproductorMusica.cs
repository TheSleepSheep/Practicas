using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReproductorMusica : MonoBehaviour
{
    public static ReproductorMusica instance;
    public AudioSource repAudio;
    public List<AudioClip> album_01 = new List<AudioClip>();
    public Transform trackContainer;
    public GameObject trackObj;
    public int currentTrack;
    public Slider volumenControl;

    private void Awake()
    {
       instance = this;
    }

    void Start()
    {
        for (int i = 0; i < album_01.Count; i++) 
        {
            Instantiate(trackObj, trackContainer);
            trackObj.GetComponent<TrackMusica>().clip = album_01[i];
            trackObj.GetComponent<TrackMusica>().idTrack = i;
        }
    }

    private void Update()
    {
        repAudio.volume = volumenControl.value;
    }

    public void Forward()
    {
        if (currentTrack < album_01.Count -1)
        {
            currentTrack++;
            repAudio.clip = album_01[currentTrack];
            repAudio.Play();
        }
        else
        {
            currentTrack = 0;
            repAudio.clip = album_01[0];
            repAudio.Play();
        }
    }

    public void Backward()
    {
        if (currentTrack > 0)
        {
            currentTrack--;
            repAudio.clip = album_01[currentTrack];
            repAudio.Play();
        }
        else
        {
            currentTrack = album_01.Count -1;
            repAudio.clip = album_01[currentTrack];
            repAudio.Play();
        }
    }
}
