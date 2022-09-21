using Evereal.VRVideoPlayer;
using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class InitialControllerInput : MonoBehaviour
    {
        public GameObject canvasObject;
        public ScreenManager screenManager;
        public VRImageSelection vRImageSelection;
        public bool onetime = false;
        public bool isAbuttonClicked = false;
        public float time;
        public float delayedTime;
        public bool isIdleTimeReached = false;

        public bool modGodspeed = false;
        // Start is called before the first frame update
        void Start()
        {
            screenManager.ControllerUI(true);
            time = 0;
            delayedTime = 3;
        }

        // Update is called once per frame
        void Update()
        {
            if (OVRInput.GetDown(OVRInput.Button.One))
            {
                if (this.modGodspeed)
                {
                    //this.speedMult = 1f;
                    print("Off");
                    screenManager.ControllerUI(true);
                    this.modGodspeed = false;
                }
                else if (!this.modGodspeed)
                {
                    //this.speedMult = 5f;
                    print("On");
                    screenManager.ControllerUI(false);
                    this.modGodspeed = true;
                }
            }
        }
    }
}