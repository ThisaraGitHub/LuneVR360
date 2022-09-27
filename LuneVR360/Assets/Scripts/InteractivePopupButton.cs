using Lune.VR360;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evereal.VRVideoPlayer
{
    public class InteractivePopupButton : ButtonBase
    {
        //public AudioSource clickSound;
        public InitialControllerInput initialControllerInput;
        public ScreenManager screenManager;
        public int indexNumber;


        public GameObject animatorCanvas;
        private Animator animCanvas;

        public GameObject panel1;
        public GameObject panel2;
        public GameObject panel3;
        public GameObject panel4;
        public GameObject panel5;
        public GameObject panel6;
        public GameObject panel7;

        // Start is called before the first frame update
        void Start()
        {
            animCanvas = animatorCanvas.GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnClick()
        {
            initialControllerInput.modGodspeed = false;
            // clickSound.Play();
            switch (indexNumber)
            {
                case 0:
                    //screenManager.ControllerUI(true);
                    //screenManager.TittleScreenUI(false);
                    //screenManager.AboutTheApp(false);
                    //screenManager.ControlButtonsDescription(false);
                    //screenManager.CitySelection(false);
                    //screenManager.PathSelection(false);
                    //screenManager.HotspotSelection(false);
                    if (!panel1.activeSelf)
                    {
                        panel1.SetActive(true);
                    }
                    animCanvas.Play("Panel-1-IN");
                    break;
                case 1:
                    //screenManager.ControllerUI(false);
                    //screenManager.TittleScreenUI(true);
                    //screenManager.AboutTheApp(false);
                    //screenManager.ControlButtonsDescription(false);
                    //screenManager.CitySelection(false);
                    //screenManager.PathSelection(false);
                    //screenManager.HotspotSelection(false);
                    if (!panel2.activeSelf)
                    {
                        panel2.SetActive(true);
                    }
                    animCanvas.Play("Panel-2-IN");
                    break;
                case 2:
                    //screenManager.ControllerUI(false);
                    //screenManager.TittleScreenUI(false);
                    //screenManager.ControlButtonsDescription(false);
                    //screenManager.CitySelection(false);
                    //screenManager.PathSelection(false);
                    //screenManager.HotspotSelection(false);
                    animCanvas.Play("Panel-2-OUT");
                    StartCoroutine(ActivateScreen("Panel3"));
                   

                    break;
                case 3:
                    //screenManager.ControllerUI(false);
                    //screenManager.TittleScreenUI(false);
                    //screenManager.AboutTheApp(false);
                    //screenManager.ControlButtonsDescription(true);
                    //screenManager.CitySelection(false);
                    //screenManager.PathSelection(false);
                    //screenManager.HotspotSelection(false);
                    animCanvas.Play("Panel-3-OUT");
                    StartCoroutine(ActivateScreen("Panel4"));
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

        IEnumerator ActivateScreen(string name)
        {
            yield return new WaitForSeconds(1.5f);
            switch (name)
            {
                case "Panel3":
                    panel2.SetActive(false);
                    if (!panel3.activeSelf)
                    {
                        panel3.SetActive(true);
                    }
                    animCanvas.Play("Panel-3-IN");
                    break;
                case "Panel4":
                    panel3.SetActive(false);
                    if (!panel4.activeSelf)
                    {
                        panel4.SetActive(true);
                    }
                    animCanvas.Play("Panel-4-IN");
                    break;
            }
        }
    }
}
