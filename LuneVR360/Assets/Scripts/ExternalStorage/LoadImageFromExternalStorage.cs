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

    // Reference image for the main menu
    private string initial360Image = "menu.png";

    /// <summary>
    // Bad Designed City
    /// </summary>
    // Bad Designed City Route 1 image refrences
    private string route1Hostpot1BadConseq = "R1-H1-bad-conseq.png";
    private string route1Hostpot2BadConseq = "R1-H2-bad-conseq.png";
    private string route1Hostpot3BadConseq = "R1-H3-bad-conseq.png";
    private string route1Hostpot4BadConseq = "R1-H4-bad-conseq.png";
    private string route1Hostpot5BadConseq = "R1-H5-bad-conseq.png";
    private string route1Hostpot6BadConseq = "R1-H6-bad-conseq.png";
    private string route1Hostpot7BadConseq = "R1-H7-bad-conseq.png";
    private string route1Hostpot8BadConseq = "R1-H8-bad-conseq.png";
    private string route1Hostpot9BadConseq = "R1-H9-bad-conseq.png";

    // Bad Designed City Route 2 image refrences
    private string route2Hostpot1BadConseq = "R2-H1-bad-conseq.png";
    private string route2Hostpot2BadConseq = "R2-H2-bad-conseq.png";
    private string route2Hostpot3BadConseq = "R2-H3-bad-conseq.png";
    private string route2Hostpot4BadConseq = "R2-H4-bad-conseq.png";

    // Bad Designed City Route 3 image refrences
    private string route3Hostpot1BadConseq = "R3-H1-bad-conseq.png";
    private string route3Hostpot2BadConseq = "R3-H2-bad-conseq.png";
    private string route3Hostpot3BadConseq = "R3-H3-bad-conseq.png";
    private string route3Hostpot4BadConseq = "R3-H4-bad-conseq.png";
    private string route3Hostpot5BadConseq = "R3-H5-bad-conseq.png";
    private string route3Hostpot6BadConseq = "R3-H6-bad-conseq.png";
    private string route3Hostpot7BadConseq = "R3-H7-bad-conseq.png";
    private string route3Hostpot8BadConseq = "R3-H8-bad-conseq.png";
    private string route3Hostpot9BadConseq = "R3-H9-bad-conseq.png";

    /// <summary>
    // Bad Designed City
    /// </summary>
    // Well Designed City Route 1 image refrences
    private string route1Hostpot1GoodConseq = "R1-H1-good-conseq.png";
    private string route1Hostpot2GoodConseq = "R1-H2-good-conseq.png";
    private string route1Hostpot3GoodConseq = "R1-H3-good-conseq.png";
    private string route1Hostpot4GoodConseq = "R1-H4-good-conseq.png";
    private string route1Hostpot5GoodConseq = "R1-H5-good-conseq.png";
    private string route1Hostpot6GoodConseq = "R1-H6-good-conseq.png";
    private string route1Hostpot7GoodConseq = "R1-H7-good-conseq.png";
    private string route1Hostpot8GoodConseq = "R1-H8-good-conseq.png";
    private string route1Hostpot9GoodConseq = "R1-H9-good-conseq.png";

    // Well Designed City Route 2 image refrences
    private string route2Hostpot1GoodConseq = "R2-H1-good-conseq.png";
    private string route2Hostpot2GoodConseq = "R2-H2-good-conseq.png";
    private string route2Hostpot3GoodConseq = "R2-H3-good-conseq.png";
    private string route2Hostpot4GoodConseq = "R2-H4-good-conseq.png";

    // Well Designed City Route 3 image refrences
    private string route3Hostpot1GoodConseq = "R3-H1-good-conseq.png";
    private string route3Hostpot2GoodConseq = "R3-H2-good-conseq.png";
    private string route3Hostpot3GoodConseq = "R3-H3-good-conseq.png";
    private string route3Hostpot4GoodConseq = "R3-H4-good-conseq.png";
    private string route3Hostpot5GoodConseq = "R3-H5-good-conseq.png";
    private string route3Hostpot6GoodConseq = "R3-H6-good-conseq.png";
    private string route3Hostpot7GoodConseq = "R3-H7-good-conseq.png";
    private string route3Hostpot8GoodConseq = "R3-H8-good-conseq.png";
    private string route3Hostpot9GoodConseq = "R3-H9-good-conseq.png";


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

    public void Switch360ConsequencesImages()
    {
        //if (Application.platform == RuntimePlatform.Android)
        //{
        //    _rootPath = Application.persistentDataPath;
        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath1Selected)
        {
            BadCityPath1ConsequncesImagesLoad();
        }
        else if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath2Selected)
        {
            BadCityPath2ConsequncesImagesLoad();
        }
        else if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath3Selected)
        {
            BadCityPath3ConsequncesImagesLoad();
        }

        if (screen5ContentManager.isWellDesignedCitySelected && screen6ContentManager.isBadCityPath1Selected)
        {
            print("Well Designed City Path 1 Selected");
            WellDesignedCityPath1ConsequncesImagesLoad();
        }
        else if (screen5ContentManager.isWellDesignedCitySelected && screen6ContentManager.isBadCityPath2Selected)
        {
            print("Well Designed City Path 2 Selected");
            WellDesignedCityPath2ConsequncesImagesLoad();
        }
        else if (screen5ContentManager.isWellDesignedCitySelected && screen6ContentManager.isBadCityPath3Selected)
        {
            print("Well Designed City Path 3 Selected");
            WellDesignedCityPath3ConsequncesImagesLoad();

        }
        //}
    }
    private void BadCityPath1ConsequncesImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route1Hostpot1BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot1"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 1:
                SetTexture(route1Hostpot2BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot2"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -80f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 2:
                SetTexture(route1Hostpot3BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot3"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -45.57f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 3:
                SetTexture(route1Hostpot4BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot4"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 102f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 4:
                SetTexture(route1Hostpot5BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot5"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -75.2f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 5:
                SetTexture(route1Hostpot6BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot6"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 120.87f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 6:
                SetTexture(route1Hostpot7BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot7"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 161.41f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 7:
                SetTexture(route1Hostpot8BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot8"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 15f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 8:
                SetTexture(route1Hostpot9BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P1-CONS-HotSpot9"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 20.4f, 0f);
                //////////////////////////
                nextHotspotLoadIcon.GetComponent<SpriteRenderer>().enabled = false;
                nextHotspotLoadIcon.GetComponent<BoxCollider>().enabled = false;
                EnableInteractivityForTheNexthotspotButton(false);
                Invoke("DeactivateHotspotIcon", 2f);
                break;
        }
    }
    private void BadCityPath2ConsequncesImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route2Hostpot1BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P2-CONS-HotSpot1"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -19.5f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 1:
                SetTexture(route2Hostpot2BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P2-CONS-HotSpot2"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 61.2f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 2:
                SetTexture(route2Hostpot3BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P2-CONS-HotSpot3"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -97f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 3:
                SetTexture(route2Hostpot4BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P2-CONS-HotSpot4"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -83.8f, 0f);
                EnableInteractivityForTheNexthotspotButton(false);
                Invoke("DeactivateHotspotIcon", 2f);
                break;
        }
    }
    private void BadCityPath3ConsequncesImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route3Hostpot1BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot1"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 127.9f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 1:
                SetTexture(route3Hostpot2BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot2"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 13.6f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 2:
                SetTexture(route3Hostpot3BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot3"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 13.6f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 3:
                SetTexture(route3Hostpot4BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot4"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -26.6f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 4:
                SetTexture(route3Hostpot5BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot5"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 11.7f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 5:
                SetTexture(route3Hostpot6BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot6"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 79f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 6:
                SetTexture(route3Hostpot7BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot7"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -9.3f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 7:
                SetTexture(route3Hostpot8BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot8"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 200f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 8:
                SetTexture(route3Hostpot9BadConseq);
                StartCoroutine(PlayVoiceovers("BD-P3-CONS-HotSpot9"));
                EnableInteractivityForTheNexthotspotButton(true);
                nextHotspotLoadIcon.GetComponent<SpriteRenderer>().enabled = false;
                nextHotspotLoadIcon.GetComponent<BoxCollider>().enabled = false;
                EnableInteractivityForTheNexthotspotButton(false);
                Invoke("DeactivateHotspotIcon", 2f);
                break;
        }
    }


    private void WellDesignedCityPath1ConsequncesImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route1Hostpot1GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot1"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 151.06f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 1:
                SetTexture(route1Hostpot2GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot2"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -73.15f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 2:
                SetTexture(route1Hostpot3GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot3"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -45.57f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 3:
                SetTexture(route1Hostpot4GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot4"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 62.95f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 4:
                SetTexture(route1Hostpot5GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot5"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -75.2f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 5:
                SetTexture(route1Hostpot6GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot6"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 120.87f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 6:
                SetTexture(route1Hostpot7GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot7"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 161.41f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 7:
                SetTexture(route1Hostpot8GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot8"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 20.4f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 8:
                SetTexture(route1Hostpot9GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P1-CONS-HotSpot9"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 20.4f, 0f);
                //////////////////////////
                nextHotspotLoadIcon.GetComponent<SpriteRenderer>().enabled = false;
                nextHotspotLoadIcon.GetComponent<BoxCollider>().enabled = false;
                EnableInteractivityForTheNexthotspotButton(false);
                Invoke("DeactivateHotspotIcon", 2f);
                break;
        }
    }
    private void WellDesignedCityPath2ConsequncesImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route2Hostpot1GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P2-CONS-HotSpot1"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -19.5f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 1:
                SetTexture(route2Hostpot2GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P2-CONS-HotSpot2"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 61.2f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 2:
                SetTexture(route2Hostpot3GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P2-CONS-HotSpot3"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -97f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 3:
                SetTexture(route2Hostpot4GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P2-CONS-HotSpot4"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -83.8f, 0f);
                EnableInteractivityForTheNexthotspotButton(false);
                Invoke("DeactivateHotspotIcon", 2f);
                break;
        }
    }
    private void WellDesignedCityPath3ConsequncesImagesLoad()
    {
        switch (NumberHighlight.hotspotNumber)
        {
            case 0:
                SetTexture(route3Hostpot1GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot1"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 127.9f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 1:
                SetTexture(route3Hostpot2GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot2"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 13.6f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 2:
                SetTexture(route3Hostpot3GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot3"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 13.6f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 3:
                SetTexture(route3Hostpot4GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot4"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -26.6f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 4:
                SetTexture(route3Hostpot5GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot5"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 11.7f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 5:
                SetTexture(route3Hostpot6GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot6"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 79f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 6:
                SetTexture(route3Hostpot7GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot7"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, -9.3f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 7:
                SetTexture(route3Hostpot8GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot8"));
                nextHotspotIcon.transform.localRotation = Quaternion.Euler(0f, 200f, 0f);
                EnableInteractivityForTheNexthotspotButton(true);
                break;
            case 8:
                SetTexture(route3Hostpot9GoodConseq);
                StartCoroutine(PlayVoiceovers("WD-P3-CONS-HotSpot9"));
                EnableInteractivityForTheNexthotspotButton(true);
                nextHotspotLoadIcon.GetComponent<SpriteRenderer>().enabled = false;
                nextHotspotLoadIcon.GetComponent<BoxCollider>().enabled = false;
                EnableInteractivityForTheNexthotspotButton(false);
                Invoke("DeactivateHotspotIcon", 2f);
                break;
        }
    }


    IEnumerator PlayVoiceovers(string nameofteClip)
    {
        yield return new WaitForSeconds(1);
        voiceoverPlay.SwitchConsequencesVoiceoverClips(nameofteClip);
    }
    public void DeactivateHotspotIcon()
    {
        nextHotspotLoadIcon.SetActive(false);
    }
    private void EnableInteractivityForTheNexthotspotButton(bool status)
    {
        if (status)
        {
            nextHotspotLoadIcon.GetComponent<SpriteRenderer>().enabled = true;
            nextHotspotLoadIcon.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            nextHotspotLoadIcon.GetComponent<SpriteRenderer>().enabled = false;
            nextHotspotLoadIcon.GetComponent<BoxCollider>().enabled = false;

        }
    }
}
