using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evereal.VRVideoPlayer
{
    public class InteractivePopupButton : ButtonBase
    {
        public InitialControllerInput initialControllerInput;
        public ScreenManager screenManager;
        public int indexNumber;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnClick()
        {
            initialControllerInput.modGodspeed = false;
            switch (indexNumber)
            {
                case 0:
                    screenManager.ControllerUI(true);
                    screenManager.TittleScreenUI(false);
                    screenManager.AboutTheApp(false);
                    screenManager.ControlButtonsDescription(false);
                    screenManager.CitySelection(false);
                    screenManager.PathSelection(false);
                    screenManager.HotspotSelection(false);
                    break;
                case 1:
                    screenManager.ControllerUI(false);
                    screenManager.TittleScreenUI(true);
                    screenManager.AboutTheApp(false);
                    screenManager.ControlButtonsDescription(false);
                    screenManager.CitySelection(false);
                    screenManager.PathSelection(false);
                    screenManager.HotspotSelection(false);
                    break;
                case 2:
                    screenManager.ControllerUI(false);
                    screenManager.TittleScreenUI(false);
                    screenManager.AboutTheApp(true);
                    screenManager.ControlButtonsDescription(false);
                    screenManager.CitySelection(false);
                    screenManager.PathSelection(false);
                    screenManager.HotspotSelection(false);
                    break;
                case 3:
                    screenManager.ControllerUI(false);
                    screenManager.TittleScreenUI(false);
                    screenManager.AboutTheApp(false);
                    screenManager.ControlButtonsDescription(true);
                    screenManager.CitySelection(false);
                    screenManager.PathSelection(false);
                    screenManager.HotspotSelection(false);
                    break;
                case 4:
                    screenManager.ControllerUI(false);
                    screenManager.TittleScreenUI(false);
                    screenManager.AboutTheApp(false);
                    screenManager.ControlButtonsDescription(false);
                    screenManager.CitySelection(true);
                    screenManager.PathSelection(false);
                    screenManager.HotspotSelection(false);
                    break;
                case 5:
                    screenManager.ControllerUI(false);
                    screenManager.TittleScreenUI(false);
                    screenManager.AboutTheApp(false);
                    screenManager.ControlButtonsDescription(false);
                    screenManager.CitySelection(false);
                    screenManager.PathSelection(true);
                    screenManager.HotspotSelection(false);
                    break;
                case 6:
                    screenManager.ControllerUI(false);
                    screenManager.TittleScreenUI(false);
                    screenManager.AboutTheApp(false);
                    screenManager.ControlButtonsDescription(false);
                    screenManager.CitySelection(false);
                    screenManager.PathSelection(false);
                    screenManager.HotspotSelection(true);
                    break;
            }
        }
    }
}
