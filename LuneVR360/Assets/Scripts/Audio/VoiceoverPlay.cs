using Evereal.VRVideoPlayer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceoverPlay : MonoBehaviour
{
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

    }

    public void SwitchConsequencesVoiceoverClips(string ClipName) 
    {
        // Bad Designed City Selected
        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath1Selected)
        {
            switch (ClipName)
            {
                case "BD-P1-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot2":
                    if (!audioSource.isPlaying )
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot5":
                    if (!audioSource.isPlaying )
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot5");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot6":
                    if (!audioSource.isPlaying )
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot6");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot7":
                    if (!audioSource.isPlaying )
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot7");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot8":
                    if (!audioSource.isPlaying )
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot8");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P1-CONS-HotSpot9":
                    if (!audioSource.isPlaying )
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-P1-CONS-HotSpot9");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
            }
        }
        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath2Selected)
        {
            switch (ClipName)
            {
                case "BD-P2-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P2-CONS-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P2-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P2-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_2/BD-P2-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
            }
        }
        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath3Selected)
        {
            switch (ClipName)
            {
                case "BD-P3-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot5":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot5");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot6":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot6");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot7":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot7");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot8":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot8");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "BD-P3-CONS-HotSpot9":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_3/BD-P3-CONS-HotSpot9");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
            }
        }

        // Well Designed City Selected
        if (screen5ContentManager.isWellDesignedCitySelected && screen6ContentManager.isBadCityPath1Selected)
        {
            switch (ClipName)
            {
                case "WD-P1-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P1-CONS-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P1-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P1-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P1-CONS-HotSpot5":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot5");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P1-CONS-HotSpot6":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot6");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P1-CONS-HotSpot7":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot7");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P1-CONS-HotSpot8":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot8");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P1-CONS-HotSpot9":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_1/WD-P1-CONS-HotSpot9");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
            }
        }
        if (screen5ContentManager.isWellDesignedCitySelected && screen6ContentManager.isBadCityPath2Selected)
        {
            switch (ClipName)
            {
                case "WD-P2-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_2/WD-P2-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P2-CONS-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_2/WD-P2-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P2-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_2/WD-P2-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P2-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_2/WD-P2-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
            }
        }
        if (screen5ContentManager.isWellDesignedCitySelected && screen6ContentManager.isBadCityPath3Selected)
        {
            switch (ClipName)
            {
                case "WD-P3-CONS-HotSpot1":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot1");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P3-CONS-HotSpot2":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot2");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P3-CONS-HotSpot3":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot3");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P3-CONS-HotSpot4":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot4");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P3-CONS-HotSpot5":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot5");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P3-CONS-HotSpot6":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot6");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P3-CONS-HotSpot7":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot7");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P3-CONS-HotSpot8":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot8");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
                case "WD-P3-CONS-HotSpot9":
                    if (!audioSource.isPlaying)
                    {
                        AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Well_Designed_City/Path_3/WD-P3-CONS-HotSpot9");
                        audioSource.PlayOneShot(BDHotSpot1);
                    }
                    break;
            }
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
