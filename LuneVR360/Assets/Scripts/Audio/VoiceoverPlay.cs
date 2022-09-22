using Evereal.VRVideoPlayer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceoverPlay : MonoBehaviour
{
    public SceneToggleButton sceneToggleButton;
    public AudioSource audioSource;
    public bool BD_P1_CONS_HotSpot1_Played = false;
    public bool BD_P1_CONS_HotSpot2_Played = false;
    public bool BD_P1_CONS_HotSpot3_Played = false;
    public bool BD_P1_CONS_HotSpot4_Played = false;
    public bool BD_P1_CONS_HotSpot5_Played = false;
    public bool BD_P1_CONS_HotSpot6_Played = false;
    public bool BD_P1_CONS_HotSpot7_Played = false;
    public bool BD_P1_CONS_HotSpot8_Played = false;
    public bool BD_P1_CONS_HotSpot9_Played = false;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (sceneToggleButton.isToggle)
        {
            switch (NumberHighlight.hotspotNumber)
            {
                case 0:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot1_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot1_Played = true;
                    }
                    break;
                case 1:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot2_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot2_Played = true;
                    }
                    break;
                case 2:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot3_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot3_Played = true;
                    }
                    break;
                case 3:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot4_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot4_Played = true;
                    }
                    break;
                case 4:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot5_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot5");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot5_Played = true;
                    }
                    break;
                case 5:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot6_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot6");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot6_Played = true;
                    }
                    break;
                case 6:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot7_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot7");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot7_Played = true;
                    }
                    break;
                case 7:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot8_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot8");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot8_Played = true;
                    }
                    break;
                case 8:
                    if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot9_Played)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot9");
                        audioSource.PlayOneShot(BDHotSpot1);
                        BD_P1_CONS_HotSpot9_Played = true;
                    }
                    break;
            }
        }
    }

    public void SwitchVoiceoverClips(string name)
    {
        switch (name)
        {
            case "BD-HotSpot1":
                if (!audioSource.isPlaying)
                {
                    if (!sceneToggleButton.isToggle)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot1");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                }
                break;
            case "BD-HotSpot2":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot2 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot2");
                    audioSource.PlayOneShot(BDHotSpot2);
                }
                break;
            case "BD-HotSpot3":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot3 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot3");
                    audioSource.PlayOneShot(BDHotSpot3);
                }
                break;
            case "BD-HotSpot4":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot4 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot4");
                    audioSource.PlayOneShot(BDHotSpot4);
                }
                break;
            case "BD-HotSpot5":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot5 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot5");
                    audioSource.PlayOneShot(BDHotSpot5);
                }
                break;
            case "BD-HotSpot6":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot6 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot6");
                    audioSource.PlayOneShot(BDHotSpot6);
                }
                break;
            case "BD-HotSpot7":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot7 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot7");
                    audioSource.PlayOneShot(BDHotSpot7);
                }
                break;
            case "BD-HotSpot8":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot8 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot8");
                    audioSource.PlayOneShot(BDHotSpot8);
                }
                break;
            case "BD-HotSpot9":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot9 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot9");
                    audioSource.PlayOneShot(BDHotSpot9);
                }
                break;
        }
    }
    public void StopVoicePlay()
    {
        audioSource.Stop();
    }
    public void PlayVoicePlay()
    {
        audioSource.Play();
    }
    public void ResetPlayStatus() 
    {
        BD_P1_CONS_HotSpot1_Played = false;
        BD_P1_CONS_HotSpot2_Played = false;
        BD_P1_CONS_HotSpot3_Played = false;
        BD_P1_CONS_HotSpot4_Played = false;
        BD_P1_CONS_HotSpot5_Played = false;
        BD_P1_CONS_HotSpot6_Played = false;
        BD_P1_CONS_HotSpot7_Played = false;
        BD_P1_CONS_HotSpot8_Played = false;
        BD_P1_CONS_HotSpot9_Played = false;
    }
}
