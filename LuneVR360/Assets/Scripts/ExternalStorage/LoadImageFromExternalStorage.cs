using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadImageFromExternalStorage : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    //public Texture text1;
    [SerializeField] private string fileName;

    private string _rootPath;
    private string _path;
    private object bytes;

    private void Awake()
    {
        Texture2D tex = new Texture2D(2, 2);
        meshRenderer = GetComponent<MeshRenderer>();
        if (Application.platform == RuntimePlatform.Android)
        {
            _rootPath = Application.persistentDataPath;
            _path = Path.Combine(_rootPath, fileName);
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
}
