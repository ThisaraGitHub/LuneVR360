using Evereal.VRVideoPlayer;
using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class InitialControllerInput : MonoBehaviour
    {
        public InteractivePopupButton interactivePopupButton;
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
                // I have limited the A button unitill user reaced to the hotspot selection
                // There is a problem with a animations that when we disable the panel and enable it again the animation state is not playing propoerly 
                // That is the reason I make this decision 

                // You can check the issue in 2 places
                // Place 1) if you comment  && vRImageSelection.isScreen7Enabled in below if statement and run the app till you reac the screen 6, which is the screen before the hotspot selection
                // And then you press the A button and hide the panel
                // Press A again to enable the panale again, and then navigate to the hostspot selection./ The previous screen animation is not closing and if you press the back button you will see screes are overlapping
                // Those screens are handeling in the script called InteractivePopupButton

                // Place 2)  if you navigate to the hotspot selection screen and navigate to randowm hotspot and press A button. 
                // The panel will close and Press A again to activate
                // Then click nex or previous button to select a hotspot
                // You will see he previous animated number is no resting or it's stuck

                // Those are the two points I need to disscuss with you to overcome
                // Thank you 

                if (OVRInput.GetDown(OVRInput.Button.One) && vRImageSelection.isScreen7Enabled)
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
            screenManager.MenuAudioPlay();
            screenManager.TittleScreenUI(true);
            panel1.SetActive(false);
        }
    }
}