using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;
namespace YoutubePlayer
{
    public class VideoController : MonoBehaviour
    {

        public YoutubePlayer youtubePlayer;
        VideoPlayer videoPlayer;

        private void Start()
        {
            videoPlayer = youtubePlayer.GetComponent<VideoPlayer>();
            Prepare();

        }

        public async void Prepare()
        {
            try
            {
                await youtubePlayer.PrepareVideoAsync();
                videoPlayer.Play();
            }
            catch
            {
                print("Erro");
            }
        }

        public void BackVideo()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
        }
    }
}


