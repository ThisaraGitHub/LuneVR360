using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FM;
using UnityEngine.UI;

public class ContentManager : MonoBehaviour
{
    [SerializeField] private CarouselView carouselView;
    public int panelNumber;
    public Text tittleText;
    public Text bodyText;
    // Start is called before the first frame update
    void Start()
    {


    }

    private void LateUpdate()
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
                        tittleText.text = "WYBIERZ MIASTO";
                        bodyText.text = "Content 01 ";
                        break;
                           
                }
                break;
        }
    }
}
