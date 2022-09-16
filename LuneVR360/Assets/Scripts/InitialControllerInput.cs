using Evereal.VRVideoPlayer;
using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class InitialControllerInput : MonoBehaviour
    {
        public ScreenManager screenManager;
        public VRImageSelection vRImageSelection;
        private bool onetime = false;
        // Start is called before the first frame update
        void Start()
        {
            screenManager.ControllerUI(true);
        }

        // Update is called once per frame
        void Update()
        {
            if (!screenManager.isPanel2Enabled &&
                !screenManager.isPanel3Enabled &&
                !screenManager.isPanel4Enabled &&
                !screenManager.isPanel5Enabled &&
                !screenManager.isPanel6Enabled &&
                !screenManager.isPanel7Enabled)
            {
                if (OVRInput.Get(OVRInput.Button.One))
                {
                    if (!onetime)
                    {
                        Debug.Log("A button pressed");
                        screenManager.ControllerUI(false);
                        screenManager.TittleScreenUI(true);
                        onetime = true;
                    }
                }

               
            }

            if (onetime &&
                   screenManager.isPanel2OpnedOnce &&
                   screenManager.isPanel3OpnedOnce &&
                   screenManager.isPanel4OpnedOnce &&
                   screenManager.isPanel5OpnedOnce &&
                   screenManager.isPanel6OpnedOnce &&
                   screenManager.isPanel7OpnedOnce &&
                   OVRInput.Get(OVRInput.Button.One))
            {
                vRImageSelection.Screen7ActiveStatus(true);
            }

        }
    }
}