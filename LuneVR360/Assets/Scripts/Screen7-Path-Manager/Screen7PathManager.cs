using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen7PathManager : MonoBehaviour
{
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
        if (screen5ContentManager.panelNumber == 5 && screen5ContentManager.carouselView.GetCurrentItem() == 0 && 
            screen6ContentManager.panelNumber == 6 && screen6ContentManager.carouselView.GetCurrentItem() == 0 )
        {
            badCityPath1Object.SetActive(true);
            badCityPath2Object.SetActive(false);
            badCityPath3Object.SetActive(false);
        }
        else if (screen5ContentManager.panelNumber == 5 && screen5ContentManager.carouselView.GetCurrentItem() == 0 &&
            screen6ContentManager.panelNumber == 6 && screen6ContentManager.carouselView.GetCurrentItem() == 1)
        {
            badCityPath1Object.SetActive(false);
            badCityPath2Object.SetActive(true);
            badCityPath3Object.SetActive(false);
        }
        else if (screen5ContentManager.panelNumber == 5 && screen5ContentManager.carouselView.GetCurrentItem() == 0 &&
           screen6ContentManager.panelNumber == 6 && screen6ContentManager.carouselView.GetCurrentItem() == 2)
        {
            badCityPath1Object.SetActive(false);
            badCityPath2Object.SetActive(false);
            badCityPath3Object.SetActive(true);
        }


    }
}
