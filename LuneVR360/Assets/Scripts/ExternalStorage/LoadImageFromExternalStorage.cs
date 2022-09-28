using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Evereal.VRVideoPlayer;
using System;

public class LoadImageFromExternalStorage : MonoBehaviour
{
    public ContentManager screen5ContentManager;
    public ContentManager screen6ContentManager;

    public GameObject nextHotspotIcon;
    public VoiceoverPlay voiceoverPlay;
    public GameObject nextHotspotLoadIcon;

    private MeshRenderer meshRenderer;
    private string initial360Image = "menu.png";

    // Route 1 image refrences
    private string route1Hostpot1Bad = "R1-H1-bad.png";
    private string route1Hostpot2Bad = "R1-H2-bad.png";
    private string route1Hostpot3Bad = "R1-H3-bad.png";
    private string route1Hostpot4Bad = "R1-H4-bad.png";
    private string route1Hostpot5Bad = "R1-H5-bad.png";
    private string route1Hostpot6Bad = "R1-H6-bad.png";
    private string route1Hostpot7Bad = "R1-H7-bad.png";
    private string route1Hostpot8Bad = "R1-H8-bad.png";
    private string route1Hostpot9Bad = "R1-H9-bad.png";

    private string route1Hostpot1BadConseq = "R1-H1-bad-conseq.png";
    private string route1Hostpot2BadConseq = "R1-H2-bad-conseq.png";
    private string route1Hostpot3BadConseq = "R1-H3-bad-conseq.png";
    private string route1Hostpot4BadConseq = "R1-H4-bad-conseq.png";
    private string route1Hostpot5BadConseq = "R1-H5-bad-conseq.png";
    private string route1Hostpot6BadConseq = "R1-H6-bad-conseq.png";
    private string route1Hostpot7BadConseq = "R1-H7-bad-conseq.png";
    private string route1Hostpot8BadConseq = "R1-H8-bad-conseq.png";
    private string route1Hostpot9BadConseq = "R1-H9-bad-conseq.png";

    // Route 2 image references
    private string route2Hostpot1Bad = "R2-H1-bad.png";
    private string route2Hostpot2Bad = "R2-H2-bad.png";
    private string route2Hostpot3Bad = "R2-H3-bad.png";
    private string route2Hostpot4Bad = "R2-H4-bad.png";

    private string route2Hostpot1BadConseq = "R2-H1-bad-conseq.png";
    private string route2Hostpot2BadConseq = "R2-H2-bad-conseq.png";
    private string route2Hostpot3BadConseq = "R2-H3-bad-conseq.png";
    private string route2Hostpot4BadConseq = "R2-H4-bad-conseq.png";


    private string _rootPath;
    private string _path;

    private void Awake()
    {
        SetTexture(initial360Image);

    }
    private void Start()
    {

    }
    private void SetTexture(string imageName)
    {
        Texture2D tex = new Texture2D(2, 2);
        meshRenderer = GetComponent<MeshRenderer>();
        if (Application.platform == RuntimePlatform.Android)
        {
            _rootPath = Application.persistentDataPath;
            _path = Path.Combine(_rootPath, imageName);
        }
        meshRenderer.material.SetTexture("_MainTex", LoadTexture(_path));
    }
    private Texture2D LoadTexture(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return null;
        }

        if (System.IO.File.Exists(path))
        {
            byte[] bytes = File.ReadAllBytes(path);
            Texture2D texture = new Texture2D(900, 900, TextureFormat.RGB24, false);
            texture.filterMode = FilterMode.Trilinear;
            texture.LoadImage(bytes);
            return texture;
        }
        return null;
    }

    public void Switch360Images()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _rootPath = Application.persistentDataPath;
            if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath1Selected)
            {
                BadCityPath1_360ImagesLoad();
            }
            else if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath2Selected)
            {
                BadCityPath2_360ImageLoad();
            }

    }
}

    public void Switch360ConsequencesImages()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _rootPath = Application.persistentDataPath;
            if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath1Selected)
            {
                BadCityPath1ConsequncesImagesLoad();
            }
            else if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath2Selected)
            {
                BadCityPath2ConsequncesImagesLoad();
            }
        }
    }



    private void BadCityPath1_360ImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route1Hostpot1Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot1"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 151.06f, 0f);
                break;
            case 1:
                SetTexture(route1Hostpot2Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot2"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -73.15f, 0f);
                break;
            case 2:
                SetTexture(route1Hostpot3Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot3"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -45.57f, 0f);
                break;
            case 3:
                SetTexture(route1Hostpot4Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot4"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 62.95f, 0f);
                break;
            case 4:
                SetTexture(route1Hostpot5Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot5"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -75.2f, 0f);
                break;
            case 5:
                SetTexture(route1Hostpot6Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot6"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 120.87f, 0f);
                break;
            case 6:
                SetTexture(route1Hostpot7Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot7"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 161.41f, 0f);
                break;
            case 7:
                SetTexture(route1Hostpot8Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot8"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 20.4f, 0f);
                break;
            case 8:
                SetTexture(route1Hostpot9Bad);
                StartCoroutine(PlayVoiceovers("BD-HotSpot9"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 20.4f, 0f);
                nextHotspotLoadIcon.SetActive(false);
                break;
        }
    }
    private void BadCityPath1ConsequncesImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route1Hostpot1BadConseq);
                break;
            case 1:
                SetTexture(route1Hostpot2BadConseq);
                break;
            case 2:
                SetTexture(route1Hostpot3BadConseq);
                break;
            case 3:
                SetTexture(route1Hostpot4BadConseq);
                break;
            case 4:
                SetTexture(route1Hostpot5BadConseq);
                break;
            case 5:
                SetTexture(route1Hostpot6BadConseq);
                break;
            case 6:
                SetTexture(route1Hostpot7BadConseq);
                break;
            case 7:
                SetTexture(route1Hostpot8BadConseq);
                break;
            case 8:
                SetTexture(route1Hostpot9BadConseq);
                break;
        }
    }

    private void BadCityPath2_360ImageLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route2Hostpot1Bad);
                StartCoroutine(PlayVoiceovers("BD-P2-HotSpot1"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 19.5f, 0f);
                break;
            case 1:
                SetTexture(route2Hostpot2Bad);
                StartCoroutine(PlayVoiceovers("BD-P2-HotSpot2"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 61.2f, 0f);
                break;
            case 2:
                SetTexture(route2Hostpot3Bad);
                StartCoroutine(PlayVoiceovers("BD-P2-HotSpot3"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 97f, 0f);
                break;
            case 3:
                SetTexture(route2Hostpot4Bad);
                StartCoroutine(PlayVoiceovers("BD-P2-HotSpot4"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 83.8f, 0f);
                break;
        }
    }
    private void BadCityPath2ConsequncesImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route2Hostpot1BadConseq);
                break;
            case 1:
                SetTexture(route2Hostpot2BadConseq);
                break;
            case 2:
                SetTexture(route2Hostpot3BadConseq);
                break;
            case 3:
                SetTexture(route2Hostpot4BadConseq);
                break;
        }
    }

    IEnumerator PlayVoiceovers(string nameofteClip)
    {
        yield return new WaitForSeconds(1);
        voiceoverPlay.SwitchVoiceoverClips(nameofteClip);
    }
}
