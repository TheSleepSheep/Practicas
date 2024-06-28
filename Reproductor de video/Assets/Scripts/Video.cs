using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer _videoPlayer;

    public VideoClip clipVideo;
    
    void Start()
    {
        _videoPlayer.clip = clipVideo;
    }

    void Update()
    {
        
    }
}
