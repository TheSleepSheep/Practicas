using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoCont : MonoBehaviour
{

    public VideoPlayer video;
    public List<VideoClip> video_01 = new List<VideoClip>();
    public Transform TrackContainer;
    public GameObject Musicaobj;
    void Start()
    {
        for (int i = 0; i < video_01.Count; i++)
        {
            Instantiate(Musicaobj, TrackContainer);
            Musicaobj.GetComponent<TrackVideo>().clip = video_01[i];
        }
    }


    void Update()
    {
        
    }
}
