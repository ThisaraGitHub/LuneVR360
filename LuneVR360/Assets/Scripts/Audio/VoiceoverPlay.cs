using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceoverPlay : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchVoiceoverClips(string name)
    {
        switch (name)
        {
            case "BD-HotSpot1":
                if (!audioSource.isPlaying)
                {
                    AudioClip BDHotSpot1 = (AudioClip)Resources.Load("Voiceovers/Bad_Designed_City/Path_1/BD-HotSpot1");
                    audioSource.PlayOneShot(BDHotSpot1);

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
}
