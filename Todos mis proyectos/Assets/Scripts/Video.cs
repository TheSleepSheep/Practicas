using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer video;
    public List<VideoClip>video_01 = new List<VideoClip>();
    public Transform trackContainer;
    public GameObject listaobj;
    public int currentTrack;

    void Start()
    {
        for (int i = 0; i < video_01.Count; i++)
        {
            Instantiate(listaobj, trackContainer);
            listaobj.GetComponent<TrackVideo>().clip = video_01[i];
        }
    }

    public void Forward()
    {
        if (currentTrack < video_01.Count -1)
        {
            currentTrack++;
            video.clip = video_01[currentTrack];
            video.Play();
        }
        else
        {
            currentTrack = 0;
            video.clip = video_01[0];
            video.Play();
        }
    }

    public void Backward()
    {
        if(currentTrack < 0)
        {
            currentTrack--;
            video.clip = video_01[currentTrack];
            video.Play();   
        }
        else
        {
            currentTrack = video_01.Count -1;
            video.clip  = video_01[currentTrack];
            video.Play();
        }
    }

}