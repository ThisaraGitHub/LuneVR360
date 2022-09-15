using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FM;
using UnityEngine.UI;
using Assets.SimpleLocalization;
public class ContentManager : MonoBehaviour
{
    public CarouselView carouselView;
    public int panelNumber;
    public LocalizedText tittleText;
    public LocalizedText bodyText;
    public LocalizedText selectionText;

    public Text tittleTextDummy;
    public Text bodyTextDummy;
    public Text selectionTextDummy;
    // Start is called before the first frame update
    void Start()
    {

        SelectItem();
    }

    private void Update()
    {
        SelectItem();
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
                        //tittleText.LocalizationKey = "Panel5.Image1Tittle";
                        //bodyText.LocalizationKey = "Panel5.Image1ContentDescription";
                        //selectionText.LocalizationKey = "Panel5.Image1SelectionText";
                        //tittleText.Localize();
                        //bodyText.Localize();
                        //selectionText.Localize();

                        tittleTextDummy.text = "Bad Designed City";
                        bodyTextDummy.text = "Bad Designed City";
                        selectionTextDummy.text = "Bad City";

                        print("Bad design city selected");

                        break;
                    case 1:
                        //tittleText.LocalizationKey = "Panel5.Image2Tittle";
                        //bodyText.LocalizationKey = "Panel5.Image2ContentDescription";
                        //selectionText.LocalizationKey = "Panel5.Image2SelectionText";
                        //tittleText.Localize();
                        //bodyText.Localize();
                        //selectionText.Localize();

                        tittleTextDummy.text = "Well Designed City";
                        bodyTextDummy.text = "Well Designed City";
                        selectionTextDummy.text = "Well City";
                        break;
                }
                break;
            case 6:
                switch (carouselView.GetCurrentItem())
                {
                    case 0:
                        //tittleText.LocalizationKey = "Panel6.Image1Tittle";
                        //bodyText.LocalizationKey = "Panel6.Image1ContentDescription";
                        //selectionText.LocalizationKey = "Panel6.Image1SelectionText";
                        //tittleText.Localize();
                        //bodyText.Localize();
                        //selectionText.Localize();

                        tittleTextDummy.text = "Path 1";
                        bodyTextDummy.text = "Path 1";
                        selectionTextDummy.text = "Path 1";

                        print("Bad design city selected Path 1 selected");
                        break;
                    case 1:
                        //tittleText.LocalizationKey = "Panel6.Image2Tittle";
                        //bodyText.LocalizationKey = "Panel6.Image2ContentDescription";
                        //selectionText.LocalizationKey = "Panel6.Image2SelectionText";
                        //tittleText.Localize();
                        //bodyText.Localize();
                        //selectionText.Localize();

                        tittleTextDummy.text = "Path 2";
                        bodyTextDummy.text = "Path 2";
                        selectionTextDummy.text = "Path 2";
                        break;
                    case 2:
                        //tittleText.LocalizationKey = "Panel6.Image3Tittle";
                        //bodyText.LocalizationKey = "Panel6.Image3ContentDescription";
                        //selectionText.LocalizationKey = "Panel6.Image3SelectionText";
                        //tittleText.Localize();
                        //bodyText.Localize();
                        //selectionText.Localize();

                        tittleTextDummy.text = "Path 3";
                        bodyTextDummy.text = "Path 3";
                        selectionTextDummy.text = "Path 3";
                        break;

                }
                break;
        }
    }
}
