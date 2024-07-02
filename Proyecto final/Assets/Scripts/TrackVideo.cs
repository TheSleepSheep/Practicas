using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class TrackVideo : MonoBehaviour
{
    public VideoPlayer Play;
    public VideoClip clip;
    public TMP_Text VideoNom;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            VideoNom.text = clip.name;
            Play = FindObjectOfType<VideoPlayer>();
        }
        catch
        {
            Destroy(gameObject);
        }
    }
    public void PlayVideo()
    {
        Play.clip = clip;
        Play.Play();

    }
}
