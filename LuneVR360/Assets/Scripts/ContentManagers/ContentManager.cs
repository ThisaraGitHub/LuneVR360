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
    //public LocalizedText selectionText;
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
                        //selectionText.LocalizationKey = "Panel5.Image1SelectionText";
                        break;

                }
                break;
        }
    }
}
