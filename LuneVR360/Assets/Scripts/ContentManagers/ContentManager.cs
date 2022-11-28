using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FM;
using UnityEngine.UI;
using Assets.SimpleLocalization;
public class ContentManager : MonoBehaviour
{
    /// <summary>
    /// This script handles the path selection and content relavent to the selectied path
    /// </summary>

    public CarouselView carouselView;
    public int panelNumber;
    public LocalizedText tittleText;
    public LocalizedText bodyText;
    public LocalizedText selectionText;

    //public Text tittleTextDummy;
    //public Text bodyTextDummy;
    //public Text selectionTextDummy;

    public bool isBadCitySelected = false;
    public bool isWellDesignedCitySelected = false;

    public bool isBadCityPath1Selected = false;
    public bool isBadCityPath2Selected = false;
    public bool isBadCityPath3Selected = false;
    // Start is called before the first frame update
    void Start()
    {

        SelectItem();
    }

    private void Update()
    {
        SelectItem();
        tittleText.Localize();
        bodyText.Localize();
        selectionText.Localize();
    }
    public void SelectItem()
    {
        Debug.Log("Selected Index: " + carouselView.GetCurrentItem());
        switch (panelNumber)
        {
            case 5:
                switch (carouselView.GetCurrentItem())
                {
                    case 0:
                        tittleText.LocalizationKey = "Panel5.Image1Tittle";
                        bodyText.LocalizationKey = "Panel5.Image1ContentDescription";
                        selectionText.LocalizationKey = "Panel5.Image1SelectionText";
                      
                        isBadCitySelected = true;
                        isWellDesignedCitySelected = false;
                        print("Bad Design City Selected");

                        //tittleTextDummy.text = "Bad Designed City";
                        //bodyTextDummy.text = "Bad Designed City";
                        //selectionTextDummy.text = "Bad City";

                        break;
                    case 1:
                        tittleText.LocalizationKey = "Panel5.Image2Tittle";
                        bodyText.LocalizationKey = "Panel5.Image2ContentDescription";
                        selectionText.LocalizationKey = "Panel5.Image2SelectionText";
                        tittleText.Localize();
                        bodyText.Localize();
                        selectionText.Localize();
                        isWellDesignedCitySelected = true;
                        isBadCitySelected = false;
                        print("Well Designed City Selected");
                        //print(tittleText.LocalizationKey);
                        //print(bodyText.LocalizationKey);
                        //print(selectionText.LocalizationKey);


                        //tittleTextDummy.text = "Well Designed City";
                        //bodyTextDummy.text = "Well Designed City";
                        //selectionTextDummy.text = "Well City";
                        break;
                }
                break;
            case 6:
                switch (carouselView.GetCurrentItem())
                {
                    case 0:
                        tittleText.LocalizationKey = "Panel6.Image1Tittle";
                        bodyText.LocalizationKey = "Panel6.Image1ContentDescription";
                        selectionText.LocalizationKey = "Panel6.Image1SelectionText";
                        tittleText.Localize();
                        bodyText.Localize();
                        selectionText.Localize();
                        print("Bad design city selected Path 1 selected");
                        isBadCityPath1Selected = true;
                        isBadCityPath2Selected = false;
                        isBadCityPath3Selected = false;

                        //tittleTextDummy.text = "Path 1";
                        //bodyTextDummy.text = "Path 1";
                        //selectionTextDummy.text = "Path 1";

                        break;
                    case 1:
                        tittleText.LocalizationKey = "Panel6.Image2Tittle";
                        bodyText.LocalizationKey = "Panel6.Image2ContentDescription";
                        selectionText.LocalizationKey = "Panel6.Image2SelectionText";
                        tittleText.Localize();
                        bodyText.Localize();
                        selectionText.Localize();
                        print("Bad design city selected Path 2 selected");
                        isBadCityPath1Selected = false;
                        isBadCityPath2Selected = true;
                        isBadCityPath3Selected = false;

                        //tittleTextDummy.text = "Path 2";
                        //bodyTextDummy.text = "Path 2";
                        //selectionTextDummy.text = "Path 2";
                        break;
                    case 2:
                        tittleText.LocalizationKey = "Panel6.Image3Tittle";
                        bodyText.LocalizationKey = "Panel6.Image3ContentDescription";
                        selectionText.LocalizationKey = "Panel6.Image3SelectionText";
                        tittleText.Localize();
                        bodyText.Localize();
                        selectionText.Localize();
                        print("Bad design city selected Path 3 selected");
                        isBadCityPath1Selected = false;
                        isBadCityPath2Selected = false;
                        isBadCityPath3Selected = true;

                        //tittleTextDummy.text = "Path 3";
                        //bodyTextDummy.text = "Path 3";
                        //selectionTextDummy.text = "Path 3";
                        break;

                }
                break;
        }
    }
}
