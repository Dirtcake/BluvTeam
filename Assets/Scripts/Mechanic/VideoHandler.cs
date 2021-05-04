using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoHandler : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private bool playCheck;
    public UnityEvent onVideoFinish;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();

    }

    private void OnEnable()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
            playCheck = true;
        }
    }

    private void Update()
    {
        if (videoPlayer.isPaused && playCheck)
        {
            onVideoFinish.Invoke();
            playCheck = true;
        }
    }
}

