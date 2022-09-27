using Evereal.VRVideoPlayer;
using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class InitialControllerInput : MonoBehaviour
    {

        public GameObject animatorCanvas;
        private Animator animCanvas;

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
            animCanvas = animatorCanvas.GetComponent<Animator>();
            time = 0;
            delayedTime = 3;
        }

        // Update is called once per frame
        void Update()
        {
            //&&
            //  !screenManager.isPanel3Enabled &&
            //  !screenManager.isPanel4Enabled &&
            //  !screenManager.isPanel5Enabled &&
            //  !screenManager.isPanel6Enabled &&
            //  !screenManager.isPanel7Enabled

            if (!screenManager.isPanel2Enabled)
            {
                //if (Input.GetKeyDown("space"))
                if (OVRInput.Get(OVRInput.Button.One))
                {
                    if (!onetime)
                    {
                        Debug.Log("A button pressed");
                        //screenManager.ControllerUI(false);
                        animCanvas.Play("Panel-1-OUT");
                        //screenManager.TittleScreenUI(true);
                        //modGodspeed = true;
                        Invoke("ActivatePanel2", 1.5f);
                        onetime = true;
                    }
                }


            }

            if (screenManager.isPanel2Enabled)
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
                            animCanvas.Play("AllPanaleEnable");
                        }
                        else
                        {
                            // vRImageSelection.Screen7ActiveStatus(false);
                            //animCanvas.Play("AllPanaleDisable");
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
                            animCanvas.Play("AllPanaleDisable");
                            //StartCoroutine(PanelActiveState());
                        }
                        else
                        {
                            //vRImageSelection.Screen7ActiveStatus(true);
                            // animCanvas.Play("AllPanaleEnable");
                        }
                        this.modGodspeed = true;
                    }
                }
            }


        }

        IEnumerator PanelActiveState()
        {
            yield return new WaitForSeconds(.8f);
            canvasObject.SetActive(false);

        }
        private void ActivatePanel2()
        {
            screenManager.TittleScreenUI(true);
            panel1.SetActive(false);
        }
    }
}