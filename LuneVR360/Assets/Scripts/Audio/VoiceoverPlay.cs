using Evereal.VRVideoPlayer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceoverPlay : MonoBehaviour
{
    public LoadImageFromExternalStorage loadImageFromExternalStorage;
    public ContentManager screen5ContentManager;
    public ContentManager screen6ContentManager;

    public SceneToggleButton sceneToggleButton;
    public AudioSource audioSource;

    [HideInInspector] public bool BD_P1_CONS_HotSpot1_Played = false;
    [HideInInspector] public bool BD_P1_CONS_HotSpot2_Played = false;
    [HideInInspector] public bool BD_P1_CONS_HotSpot3_Played = false;
    [HideInInspector] public bool BD_P1_CONS_HotSpot4_Played = false;
    [HideInInspector] public bool BD_P1_CONS_HotSpot5_Played = false;
    [HideInInspector] public bool BD_P1_CONS_HotSpot6_Played = false;
    [HideInInspector] public bool BD_P1_CONS_HotSpot7_Played = false;
    [HideInInspector] public bool BD_P1_CONS_HotSpot8_Played = false;
    [HideInInspector] public bool BD_P1_CONS_HotSpot9_Played = false;

    [HideInInspector] public bool BD_P2_CONS_HotSpot1_Played = false;
    [HideInInspector] public bool BD_P2_CONS_HotSpot2_Played = false;
    [HideInInspector] public bool BD_P2_CONS_HotSpot3_Played = false;
    [HideInInspector] public bool BD_P2_CONS_HotSpot4_Played = false;

    [HideInInspector] public bool BD_P3_CONS_HotSpot1_Played = false;
    [HideInInspector] public bool BD_P3_CONS_HotSpot2_Played = false;
    [HideInInspector] public bool BD_P3_CONS_HotSpot3_Played = false;
    [HideInInspector] public bool BD_P3_CONS_HotSpot4_Played = false;
    [HideInInspector] public bool BD_P3_CONS_HotSpot5_Played = false;
    [HideInInspector] public bool BD_P3_CONS_HotSpot6_Played = false;
    [HideInInspector] public bool BD_P3_CONS_HotSpot7_Played = false;
    [HideInInspector] public bool BD_P3_CONS_HotSpot8_Played = false;
    [HideInInspector] public bool BD_P3_CONS_HotSpot9_Played = false;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        //if (sceneToggleButton.isToggle)
        if (loadImageFromExternalStorage.switch360ConsequencesImages)
        {
            //if (screen5ContentManager.isBadCitySelected || screen5ContentManager.isWellDesignedCitySelected && screen6ContentManager.isBadCityPath1Selected)
            //{
            //    switch (NumberHighlight.hotspotNumber)
            //    {
            //        case 0:
            //            if (!audioSource.isPlaying && BD_P1_CONS_HotSpot1_Played)
            //            {
            //                print("aaaaaaaa");
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot1");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot1_Played = true;
            //            }
            //            break;
            //        case 1:
            //            if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot2_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot2");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot2_Played = true;
            //            }
            //            break;
            //        case 2:
            //            if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot3_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot3");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot3_Played = true;
            //            }
            //            break;
            //        case 3:
            //            if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot4_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot4");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot4_Played = true;
            //            }
            //            break;
            //        case 4:
            //            if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot5_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot5");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot5_Played = true;
            //            }
            //            break;
            //        case 5:
            //            if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot6_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot6");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot6_Played = true;
            //            }
            //            break;
            //        case 6:
            //            if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot7_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot7");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot7_Played = true;
            //            }
            //            break;
            //        case 7:
            //            if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot8_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot8");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot8_Played = true;
            //            }
            //            break;
            //        case 8:
            //            if (!audioSource.isPlaying && !BD_P1_CONS_HotSpot9_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot9");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P1_CONS_HotSpot9_Played = true;
            //            }
            //            break;
            //    }
            //}

            //if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath2Selected)
            //{
            //    switch (NumberHighlight.hotspotNumber)
            //    {
            //        case 0:
            //            if (!audioSource.isPlaying && !BD_P2_CONS_HotSpot1_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot1");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P2_CONS_HotSpot1_Played = true;
            //            }
            //            break;
            //        case 1:
            //            if (!audioSource.isPlaying && !BD_P2_CONS_HotSpot2_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot2");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P2_CONS_HotSpot2_Played = true;
            //            }
            //            break;
            //        case 2:
            //            if (!audioSource.isPlaying && !BD_P2_CONS_HotSpot3_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot3");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P2_CONS_HotSpot3_Played = true;
            //            }
            //            break;
            //        case 3:
            //            if (!audioSource.isPlaying && !BD_P2_CONS_HotSpot4_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot4");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P2_CONS_HotSpot4_Played = true;
            //            }
            //            break;
            //    }
            //}

            //if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath3Selected)
            //{
            //    switch (NumberHighlight.hotspotNumber)
            //    {
            //        case 0:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot1_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot1");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot1_Played = true;
            //            }
            //            break;
            //        case 1:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot2_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot2");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot2_Played = true;
            //            }
            //            break;
            //        case 2:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot3_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot3");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot3_Played = true;
            //            }
            //            break;
            //        case 3:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot4_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot4");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot4_Played = true;
            //            }
            //            break;
            //        case 4:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot5_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot5");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot5_Played = true;
            //            }
            //            break;
            //        case 5:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot6_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot6");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot6_Played = true;
            //            }
            //            break;
            //        case 6:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot7_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot7");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot7_Played = true;
            //            }
            //            break;
            //        case 7:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot8_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot8");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot8_Played = true;
            //            }
            //            break;
            //        case 8:
            //            if (!audioSource.isPlaying && !BD_P3_CONS_HotSpot9_Played)
            //            {
            //                AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot9");
            //                audioSource.PlayOneShot(BDHotSpot1);
            //                BD_P3_CONS_HotSpot9_Played = true;
            //            }
            //            break;
            //    }
            //}

        }
    }

    public void SwitchVoiceoverClips(string name)
    {
        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath1Selected)
        {
            switch (name)
            {
                case "BD-P1-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDP1CONSHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot2 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDP1CONSHotSpot2);
                    }
                    break;
                case "BD-P1-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot3 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDP1CONSHotSpot3);
                    }
                    break;
                case "BD-P1-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot4 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDP1CONSHotSpot4);
                    }
                    break;
                case "BD-P1-CONS-HotSpot5":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot5 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot5");
                        audioSource.PlayOneShot(BDP1CONSHotSpot5);
                    }
                    break;
                case "BD-P1-CONS-HotSpot6":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot6 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot6");
                        audioSource.PlayOneShot(BDP1CONSHotSpot6);
                    }
                    break;
                case "BD-P1-CONS-HotSpot7":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot7 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot7");
                        audioSource.PlayOneShot(BDP1CONSHotSpot7);
                    }
                    break;
                case "BD-P1-CONS-HotSpot8":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot8 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot8");
                        audioSource.PlayOneShot(BDP1CONSHotSpot8);
                    }
                    break;
                case "BD-P1-CONS-HotSpot9":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP1CONSHotSpot9 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot9");
                        audioSource.PlayOneShot(BDP1CONSHotSpot9);
                    }
                    break;
            }
        }

        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath2Selected)
        {
            switch (name)
            {
                case "BD-P2-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP2CONSHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDP2CONSHotSpot1);
                    }
                    break;
                case "BD-P2-CONS-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP2CONSHotSpot2 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDP2CONSHotSpot2);
                    }
                    break;
                case "BD-P2-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP2CONSHotSpot3 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDP2CONSHotSpot3);
                    }
                    break;
                case "BD-P2-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP2CONSHotSpot4 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDP2CONSHotSpot4);
                    }
                    break;
            }
        }

        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath3Selected)
        {
            switch (name)
            {
                case "BD-P3-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDP3CONSHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot2 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDP3CONSHotSpot2);
                    }
                    break;
                case "BD-P3-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot3 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDP3CONSHotSpot3);
                    }
                    break;
                case "BD-P3-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot4 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDP3CONSHotSpot4);
                    }
                    break;
                case "BD-P3-CONS-HotSpot5":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot5 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot5");
                        audioSource.PlayOneShot(BDP3CONSHotSpot5);
                    }
                    break;
                case "BD-P3-CONS-HotSpot6":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot6 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot6");
                        audioSource.PlayOneShot(BDP3CONSHotSpot6);
                    }
                    break;
                case "BD-P3-CONS-HotSpot7":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot7 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot7");
                        audioSource.PlayOneShot(BDP3CONSHotSpot7);
                    }
                    break;
                case "BD-P3-CONS-HotSpot8":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot8 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot8");
                        audioSource.PlayOneShot(BDP3CONSHotSpot8);
                    }
                    break;
                case "BD-P3-CONS-HotSpot9":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDP3CONSHotSpot9 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot9");
                        audioSource.PlayOneShot(BDP3CONSHotSpot9);
                    }
                    break;
            }
        }

        if (screen5ContentManager.isWellDesignedCitySelected && screen6ContentManager.isBadCityPath1Selected)
        {
            switch (name)
            {
                case "BD-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        if (!sceneToggleButton.isToggle)
                        {
                            AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot1");
                            audioSource.PlayOneShot(BDHotSpot1);
                        }
                    }
                    break;
                case "BD-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot2 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot2");
                        audioSource.PlayOneShot(BDHotSpot2);
                    }
                    break;
                case "BD-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot3 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot3");
                        audioSource.PlayOneShot(BDHotSpot3);
                    }
                    break;
                case "BD-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot4 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot4");
                        audioSource.PlayOneShot(BDHotSpot4);
                    }
                    break;
                case "BD-HotSpot5":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot5 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot5");
                        audioSource.PlayOneShot(BDHotSpot5);
                    }
                    break;
                case "BD-HotSpot6":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot6 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot6");
                        audioSource.PlayOneShot(BDHotSpot6);
                    }
                    break;
                case "BD-HotSpot7":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot7 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot7");
                        audioSource.PlayOneShot(BDHotSpot7);
                    }
                    break;
                case "BD-HotSpot8":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot8 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot8");
                        audioSource.PlayOneShot(BDHotSpot8);
                    }
                    break;
                case "BD-HotSpot9":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot9 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/GD-HotSpot9");
                        audioSource.PlayOneShot(BDHotSpot9);
                    }
                    break;
            }
        }

    }
    public void StopVoicePlay()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
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

        BD_P2_CONS_HotSpot1_Played = false;
        BD_P2_CONS_HotSpot2_Played = false;
        BD_P2_CONS_HotSpot3_Played = false;
        BD_P2_CONS_HotSpot4_Played = false;

        BD_P3_CONS_HotSpot1_Played = false;
        BD_P3_CONS_HotSpot2_Played = false;
        BD_P3_CONS_HotSpot3_Played = false;
        BD_P3_CONS_HotSpot4_Played = false;
        BD_P3_CONS_HotSpot5_Played = false;
        BD_P3_CONS_HotSpot6_Played = false;
        BD_P3_CONS_HotSpot7_Played = false;
        BD_P3_CONS_HotSpot8_Played = false;
        BD_P3_CONS_HotSpot9_Played = false;
    }

    public void DisablePlayVoiceoversRandomly()
    {
        BD_P1_CONS_HotSpot1_Played = true;
        BD_P1_CONS_HotSpot2_Played = true;
        BD_P1_CONS_HotSpot3_Played = true;
        BD_P1_CONS_HotSpot4_Played = true;
        BD_P1_CONS_HotSpot5_Played = true;
        BD_P1_CONS_HotSpot6_Played = true;
        BD_P1_CONS_HotSpot7_Played = true;
        BD_P1_CONS_HotSpot8_Played = true;
        BD_P1_CONS_HotSpot9_Played = true;

        BD_P2_CONS_HotSpot1_Played = true;
        BD_P2_CONS_HotSpot2_Played = true;
        BD_P2_CONS_HotSpot3_Played = true;
        BD_P2_CONS_HotSpot4_Played = true;

        BD_P3_CONS_HotSpot1_Played = true;
        BD_P3_CONS_HotSpot2_Played = true;
        BD_P3_CONS_HotSpot3_Played = true;
        BD_P3_CONS_HotSpot4_Played = true;
        BD_P3_CONS_HotSpot5_Played = true;
        BD_P3_CONS_HotSpot6_Played = true;
        BD_P3_CONS_HotSpot7_Played = true;
        BD_P3_CONS_HotSpot8_Played = true;
        BD_P3_CONS_HotSpot9_Played = true;
    }
}
