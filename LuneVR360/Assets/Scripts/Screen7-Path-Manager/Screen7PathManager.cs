using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen7PathManager : MonoBehaviour
{
    /// <summary>
    /// This script manage the images for screen 7 based on the selected path
    /// </summary>
    public ContentManager screen5ContentManager;
    public ContentManager screen6ContentManager;

    public GameObject badCityPath1Object;
    public GameObject badCityPath2Object;
    public GameObject badCityPath3Object;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath1Selected)
        {
            badCityPath1Object.SetActive(true);
            badCityPath2Object.SetActive(false);
            badCityPath3Object.SetActive(false);
        }
        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath2Selected)
        {
            badCityPath1Object.SetActive(false);
            badCityPath2Object.SetActive(true);
            badCityPath3Object.SetActive(false);
        }
        if (screen5ContentManager.isBadCitySelected && screen6ContentManager.isBadCityPath3Selected)
        {
            badCityPath1Object.SetActive(false);
            badCityPath2Object.SetActive(false);
            badCityPath3Object.SetActive(true);
        }
    }
}
