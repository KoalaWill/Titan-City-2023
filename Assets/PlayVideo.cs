using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayVideo : MonoBehaviour
{
    GameObject camera = GameObject.Find("Main Camera");
    VideoPlayer videoPlayer = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();
    public bool isPlaying = false;
    // Start is called before the first frame update
    void Start() {
        videoPlayer.Stop();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        if (scene.name == "StartingVideo") {
        
            videoPlayer.Play();
            isPlaying = true;
        }
    }
}
    
    // Update is called once per frame
    //void Update()
    //{
        
    //}
