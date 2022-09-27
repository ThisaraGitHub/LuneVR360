using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class ScreenManager : MonoBehaviour
    {
        public GameObject animatorCanvas;
        private Animator animCanvas;
        public AudioSource menuPopupSound;

        public GameObject panel1;
        public GameObject panel2;
        public GameObject panel3;
        public GameObject panel4;
        public GameObject panel5;
        public GameObject panel6;
        public GameObject panel7;

        public bool isPanel2Enabled = false;
        public bool isPanel3Enabled = false;
        public bool isPanel4Enabled = false;
        public bool isPanel5Enabled = false;
        public bool isPanel6Enabled = false;
        public bool isPanel7Enabled = false;

        public bool isPanel2OpnedOnce = false;
        public bool isPanel3OpnedOnce = false;
        public bool isPanel4OpnedOnce = false;
        public bool isPanel5OpnedOnce = false;
        public bool isPanel6OpnedOnce = false;
        public bool isPanel7OpnedOnce = false;

        // Start is called before the first frame update
        void Start()
        {
            animCanvas = animatorCanvas.GetComponent<Animator>();
            ControllerUI(true);
            //TittleScreenUI(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ControllerUI(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                if (!panel1.activeSelf)
                {
                    panel1.SetActive(true);
                }
                animCanvas.Play("Panel-1-IN");
            }
            else
            {
                animCanvas.Play("Panel-1-OUT");
                // panel1.SetActive(false);
            }
        }
        public void TittleScreenUI(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                //panel2.SetActive(true);
                if (!panel2.activeSelf)
                {
                    panel2.SetActive(true);
                }
                animCanvas.Play("Panel-2-IN");
                isPanel2Enabled = true;
                isPanel2OpnedOnce = true;
                StartCoroutine(WaitandPlayAudio("Menu"));
            }
            else
            {
                // panel2.SetActive(false);
                animCanvas.Play("Panel-1-OUT");
                isPanel2Enabled = false;
            }

        }
        public void AboutTheApp(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                if (!panel3.activeSelf)
                {
                    panel3.SetActive(true);
                }
                animCanvas.Play("Panel-3-IN");
                isPanel3Enabled = true;
                isPanel3OpnedOnce = true;
                StartCoroutine(WaitandPlayAudio("Menu"));
            }
            else
            {
                animCanvas.Play("Panel-3-OUT");
                //panel3.SetActive(false);
                isPanel3Enabled = false;
            }
        }
        public void ControlButtonsDescription(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel4.SetActive(true);
                isPanel4Enabled = true;
                isPanel4OpnedOnce = true;
                StartCoroutine(WaitandPlayAudio("Menu"));
            }
            else
            {
                panel4.SetActive(false);
                isPanel4Enabled = false;
            }
        }
        public void CitySelection(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel5.SetActive(true);
                isPanel5Enabled = true;
                isPanel5OpnedOnce = true;
                StartCoroutine(WaitandPlayAudio("Menu"));
            }
            else
            {
                panel5.SetActive(false);
                isPanel5Enabled = false;
            }
        }
        public void PathSelection(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel6.SetActive(true);
                isPanel6Enabled = true;
                isPanel6OpnedOnce = true;
                StartCoroutine(WaitandPlayAudio("Menu"));
            }
            else
            {
                panel6.SetActive(false);
                isPanel6Enabled = false;
            }
        }
        public void HotspotSelection(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel7.SetActive(true);
                isPanel7Enabled = true;
                isPanel7OpnedOnce = true;
                StartCoroutine(WaitandPlayAudio("Menu"));
            }
            else
            {
                panel7.SetActive(false);
                isPanel7Enabled = false;
            }
        }


        public IEnumerator WaitandPlayAudio(string type)
        {
            switch (type)
            {
                case "Menu":
                    yield return new WaitForSeconds(0f);
                    menuPopupSound.Play();
                    break;
            }
        }
    }
}

