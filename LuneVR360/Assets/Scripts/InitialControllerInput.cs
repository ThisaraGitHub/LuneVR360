using Evereal.VRVideoPlayer;
using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class InitialControllerInput : MonoBehaviour
    {
        public GameObject panel1;

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
            //  screenManager.ControllerUI(true);
            time = 0;
            delayedTime = 3;
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
                //if (Input.GetKeyDown("space"))
                if (OVRInput.Get(OVRInput.Button.One))
                {
                    if (!onetime)
                    {
                        Debug.Log("A button pressed");
                        screenManager.ControllerUI(false);
                        modGodspeed = true;
                        Invoke("ActivatePanel2", 1.5f);
                        onetime = true;
                    }
                }


            }

            if (!screenManager.isPanel2Enabled)
            {
                if (OVRInput.GetDown(OVRInput.Button.One))
                {

                    if (this.modGodspeed)
                    {
                        //this.speedMult = 1f;
                        print("Off");
                        if (!screenManager.isPanel7Enabled)
                        {
                            canvasObject.SetActive(true);
                        }
                        else
                        {
                            vRImageSelection.Screen7ActiveStatus(false);
                        }

                        this.modGodspeed = false;
                    }
                    else if (!this.modGodspeed)
                    {
                        //this.speedMult = 5f;
                        print("On");
                        if (!screenManager.isPanel7Enabled)
                        {
                            canvasObject.SetActive(false);
                        }
                        else
                        {
                            vRImageSelection.Screen7ActiveStatus(true);
                        }
                        this.modGodspeed = true;
                    }
                }
            }


        }

        private void ActivatePanel2()
        {
            screenManager.TittleScreenUI(true);
            panel1.SetActive(false);
        }
    }
}