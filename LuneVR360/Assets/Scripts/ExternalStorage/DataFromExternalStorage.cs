using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;

public class DataFromExternalStorage : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private string fileName = "video_external.mp4";
    [SerializeField] private bool playOnAwake;

    private string _rootPath;
    private string _path;
    // private VideoPlayerController _controller;

    void Awake()
    {
        if (videoPlayer == null)
            videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.errorReceived += VideoPlayer_errorReceived;

        if (Application.platform == RuntimePlatform.Android)
        {
            _rootPath = Application.persistentDataPath;
            _path = Path.Combine(_rootPath, fileName);
        }

        videoPlayer.url = _path;

        //_controller = GetComponent<VideoPlayerController>();
    }

    private void Start()
    {
        if (playOnAwake)
        {
            //if (_controller != null)
            //{
            //    _controller.PlayVideoNoFade();
            //}
            //else
            //{
            videoPlayer.Play();
            //}
        }

        //Oo.Log("Video path: " + _path);
    }

    private void VideoPlayer_errorReceived(VideoPlayer source, string message)
    {
        //Oo.Log(message + " " + source.ToString());

        videoPlayer.errorReceived -= VideoPlayer_errorReceived;
    }
}

