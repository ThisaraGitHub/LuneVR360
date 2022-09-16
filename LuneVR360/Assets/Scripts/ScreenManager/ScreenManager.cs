using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lune.VR360
{
    public class ScreenManager : MonoBehaviour
    {
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

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ControllerUI(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel1.SetActive(true);
            }
            else
            {
                panel1.SetActive(false);
            }
        }
        public void TittleScreenUI(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel2.SetActive(true);
                isPanel2Enabled = true;
                isPanel2OpnedOnce = true;
            }
            else
            {
                panel2.SetActive(false);
                isPanel2Enabled = false;
            }

        }
        public void AboutTheApp(bool ActiveStatus)
        {
            if (ActiveStatus)
            {
                panel3.SetActive(true);
                isPanel3Enabled = true;
                isPanel3OpnedOnce = true;
            }
            else
            {
                panel3.SetActive(false);
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
            }
            else
            {
                panel7.SetActive(false);
                isPanel7Enabled = false;
            }
        }

    }
}

