using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Evereal.VRVideoPlayer;

public class LoadImageFromExternalStorage : MonoBehaviour
{

    private MeshRenderer meshRenderer;
    private string initial360Image = "test_texture.png";

    private string route1Hostpot1Bad = "R1-H1-bad.png";
    private string route2Hostpot1Bad = "R1-H2-bad.png";
    private string route3Hostpot1Bad = "R1-H3-bad.png";
    private string route4Hostpot1Bad = "R1-H4-bad.png";
    private string route5Hostpot1Bad = "R1-H5-bad.png";
    private string route6Hostpot1Bad = "R1-H6-bad.png";
    private string route7Hostpot1Bad = "R1-H7-bad.png";
    private string route8Hostpot1Bad = "R1-H8-bad.png";
    private string route9Hostpot1Bad = "R1-H9-bad.png";

    private string _rootPath;
    private string _path;
    private object bytes;

    private void Awake()
    {
        SetTexture(initial360Image);
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

            switch (NumberHighlight.hotspotNumber)
            {
                case 0:
                    SetTexture(route1Hostpot1Bad);
                    break;
                case 1:
                    SetTexture(route2Hostpot1Bad);
                    break;
                case 2:
                    SetTexture(route3Hostpot1Bad);
                    break;
                case 3:
                    SetTexture(route4Hostpot1Bad);
                    break;
                case 4:
                    SetTexture(route5Hostpot1Bad);
                    break;
                case 5:
                    SetTexture(route6Hostpot1Bad);
                    break;
                case 6:
                    SetTexture(route7Hostpot1Bad);
                    break;
                case 7:
                    SetTexture(route8Hostpot1Bad);
                    break;
                case 8:
                    SetTexture(route8Hostpot1Bad);
                    break;
            }


        }

    }
}
