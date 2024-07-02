using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class TrackVideo : MonoBehaviour
{
    public VideoPlayer reproductor;
    public VideoClip clip;
    public TMP_Text VideoName;

    void Start()
    {
        try
        { 
        VideoName.text =clip.name;
        reproductor = FindObjectOfType<VideoPlayer>();
        }
        catch 
        {
        Destroy(gameObject);
        }
    }

    public void PlayVideo()
    {
        reproductor.clip = clip;
        reproductor.Play();

    }

}
