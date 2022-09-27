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
                    if (!panel1.activeSelf)
                    {
                        panel1.SetActive(true);
                    }
                    animCanvas.Play("Panel-1-IN");
                    break;
                case 1:
                    if (!panel2.activeSelf)
                    {
                        panel2.SetActive(true);
                    }
                    animCanvas.Play("Panel-2-IN");
                    break;
                case 2:
                    animCanvas.Play("Panel-2-OUT");
                    StartCoroutine(ActivateScreen("Panel3"));
                    break;
                case 3:
                    animCanvas.Play("Panel-3-OUT");
                    StartCoroutine(ActivateScreen("Panel4"));
                    break;
                case 4:
                    animCanvas.Play("Panel-4-OUT");
                    StartCoroutine(ActivateScreen("Panel5"));
                    break;
                case 5:
                    animCanvas.Play("Panel-5-OUT");
                    StartCoroutine(ActivateScreen("Panel6"));
                    break;
                case 6:
                    animCanvas.Play("Panel-6-OUT");
                    StartCoroutine(ActivateScreen("Panel7"));
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
                case "Panel5":
                    panel4.SetActive(false);
                    if (!panel5.activeSelf)
                    {
                        panel5.SetActive(true);
                    }
                    animCanvas.Play("Panel-5-IN");
                    break;
                case "Panel6":
                    panel5.SetActive(false);
                    if (!panel6.activeSelf)
                    {
                        panel6.SetActive(true);
                    }
                    animCanvas.Play("Panel-6-IN");
                    break;
                case "Panel7":
                    panel6.SetActive(false);
                    if (!panel7.activeSelf)
                    {
                        panel7.SetActive(true);
                    }
                    animCanvas.Play("Panel-7-IN");
                    break;
            }
        }
    }
}
