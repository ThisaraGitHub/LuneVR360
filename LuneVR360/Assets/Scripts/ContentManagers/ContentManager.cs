using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FM;
using UnityEngine.UI;
using Assets.SimpleLocalization;
public class ContentManager : MonoBehaviour
{
    [SerializeField] private CarouselView carouselView;
    public int panelNumber;
    public LocalizedText tittleText;
    public LocalizedText bodyText;
    public LocalizedText selectionText;
    // Start is called before the first frame update
    void Start()
    {


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
                        tittleText.LocalizationKey = "Panel5.Image1Tittle";
                        bodyText.LocalizationKey = "Panel5.Image1ContentDescription";
                        selectionText.LocalizationKey = "Panel5.Image1SelectionText";
                        tittleText.Localize();
                        bodyText.Localize();
                        selectionText.Localize();
                        break;   
                    case 1:
                        tittleText.LocalizationKey = "Panel5.Image2Tittle";
                        bodyText.LocalizationKey = "Panel5.Image2ContentDescription";
                        selectionText.LocalizationKey = "Panel5.Image2SelectionText";
                        tittleText.Localize();
                        bodyText.Localize();
                        selectionText.Localize();
                        break;
                    case 2:
                        tittleText.LocalizationKey = "Panel5.Image3Tittle";
                        bodyText.LocalizationKey = "Panel5.Image3ContentDescription";
                        selectionText.LocalizationKey = "Panel5.Image3SelectionText";
                        tittleText.Localize();
                        bodyText.Localize();
                        selectionText.Localize();
                        break;

                }
                break;
        }
    }
}
