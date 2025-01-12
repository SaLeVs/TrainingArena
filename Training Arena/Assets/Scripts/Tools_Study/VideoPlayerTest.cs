using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerTest : MonoBehaviour
{
    private void Start()
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.Play();
    }
}
